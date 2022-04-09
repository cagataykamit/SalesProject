using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.InMemory;

namespace Business.Concrete
{
    public static class SalesManager
    {
        public static  decimal CalculateAdditionalDiscounts(decimal amount)
        {
            return Math.Floor(amount / 200) * 5;
        }
        public static decimal CalculateAllDiscounts(decimal discountRate, decimal discountableTotalAmount, decimal nonPercDiscountableTotalAmount, out decimal discountAmount)
        {
            decimal totalAmount = nonPercDiscountableTotalAmount + discountableTotalAmount;
            //müşteriye özel indirim tutarını hesapla
            discountAmount = discountableTotalAmount * discountRate;
            //ilave indirimleri ekle
            discountAmount += CalculateAdditionalDiscounts(totalAmount - discountAmount);
            //toplam indirimli tutarı hesapla
            totalAmount -= discountAmount;

            return totalAmount;
        }

        public static int DoSale()
        {
            //login
            CustomerManager customerManager = new CustomerManager(new InMemoryCustomerDal());
            Customer customer1 = customerManager.GetById(1).ElementAt(0);

            //ürünleri listele
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            List<Product> productList = productManager.GetAll();

            //sepete ürünleri ekle
            BasketManager basketManager = new BasketManager();
            Product product1 = productList.ElementAt(0);
            basketManager.AddProduct(product1);
            Product product2 = productList.ElementAt(3);
            basketManager.AddProduct(product2);
            Product product3 = productList.ElementAt(4);
            basketManager.AddProduct(product3);
            Product product4 = productList.ElementAt(5);
            basketManager.AddProduct(product4);

            //toplam sepet tutarını hesapla
            decimal discountRate = CustomerManager.GetDiscountRateForCustomer(customer1);
            decimal discountableTotalAmount = basketManager.GetDiscountableTotalAmount();
            decimal nonPercDiscountableTotalAmount = basketManager.GetNonPercDiscountableTotalAmount();
            decimal totalAmount = CalculateAllDiscounts(discountRate, discountableTotalAmount, nonPercDiscountableTotalAmount, out decimal discountAmount);

            //Faturayı düzenle
            Invoice invoice = new Invoice()
            {
                InvoiceId = 1,
                InvoiceTime = DateTime.Now,
                DiscountAmount = discountAmount,
                TotalAmount = totalAmount,
            };

            Console.WriteLine("invoiceId: " + invoice.InvoiceId);
            Console.WriteLine("InvoiceTime: " + invoice.InvoiceTime);
            Console.WriteLine("DiscountAmount: " + invoice.DiscountAmount);
            Console.WriteLine("TotalAmount: " + invoice.TotalAmount);

            return 0;
        }
    }
}

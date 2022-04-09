using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private decimal nonPercDiscountableTotalAmount;
        private decimal discountableTotalAmount;
        public void AddProduct(Product product)
        {
            if (product.CategoryId == 1)
                nonPercDiscountableTotalAmount += product.UnitPrice;
            else
                discountableTotalAmount += product.UnitPrice;
        }

        public void RemoveProduct(Product product)
        {
            if (product.CategoryId == 1)
                nonPercDiscountableTotalAmount -= product.UnitPrice;
            else
                discountableTotalAmount -= product.UnitPrice;
        }

        public decimal GetDiscountableTotalAmount()
        {
            return discountableTotalAmount;
        }

        public decimal GetNonPercDiscountableTotalAmount()
        {
            return nonPercDiscountableTotalAmount;
        }
    }
}

using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    // InMemoryProductDal : Bellek üzerinde ürünle ilgili veri erişim kodlarının yazılacağı yer
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() 
            { 
                new Product{ProductId=1, CategoryId=1, ProductName="CepTelefonu1", UnitsInStock=100, UnitPrice=4000},            
                new Product{ProductId=2, CategoryId=1, ProductName="CepTelefonu2", UnitsInStock=100, UnitPrice=6000},            
                new Product{ProductId=3, CategoryId=1, ProductName="CepTelefonu3", UnitsInStock=100, UnitPrice=8000},            
                new Product{ProductId=4, CategoryId=2, ProductName="Televizyon1", UnitsInStock=150, UnitPrice=3000},            
                new Product{ProductId=5, CategoryId=2, ProductName="Televizyon2", UnitsInStock=120, UnitPrice=4000},            
                new Product{ProductId=6, CategoryId=2, ProductName="Televizyon3", UnitsInStock=100, UnitPrice=5000},           
                new Product{ProductId=7, CategoryId=3, ProductName="Klavye1", UnitsInStock=200, UnitPrice=600},           
                new Product{ProductId=8, CategoryId=3, ProductName="Klavye2", UnitsInStock=200, UnitPrice=700},           
                new Product{ProductId=9, CategoryId=3, ProductName="Klavye3", UnitsInStock=200, UnitPrice=1600},           
                new Product{ProductId=10, CategoryId=4, ProductName="Mouse1", UnitsInStock=200, UnitPrice=300},           
                new Product{ProductId=11, CategoryId=4, ProductName="Mouse2", UnitsInStock=200, UnitPrice=500},           
                new Product{ProductId=12, CategoryId=4, ProductName="Mouse3", UnitsInStock=200, UnitPrice=1300},           
                new Product{ProductId=13, CategoryId=5, ProductName="Laptop1", UnitsInStock=100, UnitPrice=12000},           
                new Product{ProductId=14, CategoryId=5, ProductName="Laptop2", UnitsInStock=60, UnitPrice=17000},           
                new Product{ProductId=15, CategoryId=5, ProductName="Laptop3", UnitsInStock=50, UnitPrice=23000}           
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
           _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

       
    }
}

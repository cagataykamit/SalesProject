using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBasketService
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        decimal GetNonPercDiscountableTotalAmount();
        decimal GetDiscountableTotalAmount();
    }
}

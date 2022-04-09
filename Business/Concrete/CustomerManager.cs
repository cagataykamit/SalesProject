using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetById(int id)
        { 
            return _customerDal.GetAll(c=>c.Id==id);
        }
        public static decimal GetDiscountRateForCustomer(User user)
        {
            decimal discountRate = 0;
            if (user is Affiliate)
            {
                discountRate = 0.10m;
            }
            else if (user is Customer customer)
            {
                switch (customer.MemberTypeId)
                {
                    case 1:
                        discountRate = 0.30m;
                        break;
                    case 2:
                        discountRate = 0.20m;
                        break;
                    default:
                        if (customer.MembershipDate.Year >= 2)
                            discountRate = 0.05m;
                        break;
                }
            }
            return discountRate;
        }
    }
}

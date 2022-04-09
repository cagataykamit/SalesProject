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
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customers;
        public InMemoryCustomerDal()
        {
            _customers = new List<Customer>()
            {
                new Customer(){Id=1, Name="Hakkı", Surname="Ersan",MembershipDate=DateTime.Today,MemberTypeId=1},
                new Customer(){Id=2, Name="Ensar", Surname="Tiryaki",MembershipDate=DateTime.Today,MemberTypeId=2},
                new Customer(){Id=3, Name="Çağatay", Surname="Kamit",MembershipDate=DateTime.Today,MemberTypeId=3 },
                new Customer(){Id=4, Name="Mehmet", Surname="Alan", MembershipDate=DateTime.Today, MemberTypeId=1}
            };
        }
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _customers;
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}

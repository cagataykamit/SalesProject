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
    class InMemoryInvoiceDal : IInvoiceDal
    {
        public void Add(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public Invoice Get(Expression<Func<Invoice, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAll(Expression<Func<Invoice, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice entity)
        {
            throw new NotImplementedException();
        }

        
    }
}

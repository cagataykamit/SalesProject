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
    public class InMemoryAffiliateDal : IAffiliateDal
    {

        List<Affiliate> _affiliates;
        public InMemoryAffiliateDal()
        {
            _affiliates = new List<Affiliate>()
            {
                new Affiliate(){Id=1, Name="Pınar",Surname="Flütçalan" },
                new Affiliate(){Id=2, Name="Çağatay",Surname="Gitarçalan" },
                new Affiliate(){Id=3, Name="Kaşif",Surname="Neyçalan" }
            };
        }
        public void Add(Affiliate entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Affiliate entity)
        {
            throw new NotImplementedException();
        }

        public Affiliate Get(Expression<Func<Affiliate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Affiliate> GetAll(Expression<Func<Affiliate, bool>> filter = null)
        {
            return _affiliates;
        }

        public void Update(Affiliate entity)
        {
            throw new NotImplementedException();
        }

        
    }
}

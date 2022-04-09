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
    public class InMemoryMemberTypeDal: IMemberTypeDal
    {
        readonly List<MemberType> _memberTypes;
        public InMemoryMemberTypeDal()
        {
            _memberTypes = new List<MemberType>()
            {
                new MemberType(){MemberTypeId=1, MemberTypeName="Gold" },
                new MemberType(){MemberTypeId=2, MemberTypeName="Silver" },
                new MemberType(){MemberTypeId=3, MemberTypeName="Standart" }
            };
        }
        public void Add(MemberType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MemberType entity)
        {
            throw new NotImplementedException();
        }

        public MemberType Get(Expression<Func<MemberType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<MemberType> GetAll(Expression<Func<MemberType, bool>> filter = null)
        {
            return _memberTypes;
        }

        public void Update(MemberType entity)
        {
            throw new NotImplementedException();
        }

        
    }
}

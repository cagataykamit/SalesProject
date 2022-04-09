using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MemberType:IEntity
    {
        public int MemberTypeId { get; set; }
        public string MemberTypeName { get; set; }
        public List<Customer> Customers { get; set; }

    }
}

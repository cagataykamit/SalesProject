using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:User, IEntity
    {
        public int MemberTypeId { get; set; }

        [ForeignKey("MemberTypeId")]
        public MemberType MemberType { get; set; }
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime MembershipDate { get; set; }

        [ForeignKey("BasketId")]
        public Basket Basket { get; set; }
    }
}

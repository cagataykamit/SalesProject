using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Basket:IEntity
    {
        public int BasketId { get; set; }
        public int InvoiceId { get; set; }

        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}

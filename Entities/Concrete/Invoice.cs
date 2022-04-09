using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Invoice: IEntity
    {
        public int InvoiceId { get; set; }
        public DateTime InvoiceTime { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public List<Basket> Baskets { get; set; }

    }
}

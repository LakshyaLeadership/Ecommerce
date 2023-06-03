using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakshya.Ecommerce.Repositories.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Domain.Models
{
    class Shopping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  Category Category { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Cost { get; set; }
    }
}

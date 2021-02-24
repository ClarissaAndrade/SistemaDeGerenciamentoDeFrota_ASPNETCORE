using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGF.Models
{
    public class DCExpense
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DCExpenseType Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Boolean PayedByDriver { get; set; }
    }
}

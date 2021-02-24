using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGF.Models
{
    public class DryCargo
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public double TotalKM { get; set; }
        public string Material { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
        public List<City> Cities { get; set; }
        public List<DCExpense> Expenses { get; set; }     
    }
}

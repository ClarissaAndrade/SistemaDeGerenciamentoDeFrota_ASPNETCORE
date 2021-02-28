
using System.Collections.Generic;

namespace SGF.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public DryCargo dryCargo { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<State> States { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGF.Models
{
    [Table("drycargo_city")]
    public class DryCargo_City
    {

        
        [Key]
        public int id { get; set; }
        public int DryCargoId { get; set; }
        public int CityId { get; set; }

        public virtual DryCargo DryCargo { get; set; }
        public virtual City City { get; set; }
    }
}

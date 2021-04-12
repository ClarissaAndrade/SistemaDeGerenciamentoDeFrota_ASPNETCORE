using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGF.Models
{

    [Table("drycargo")]
    public class DryCargo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Valor do Frete")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Value { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Range(0.0, 10000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Total de KMs")]
        public double TotalKM { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Material { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data de Partida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DepartureDate { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data de Chegada")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ArrivalDate { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Estado de Partida")]
        public State DepartureState { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Cidade de Partida")]
        public City DepartureCity { get; set; }

        public ShippingCompany ShippingCompany { get; set; }
        public int ShippingCompanyId { get; set; }
        public virtual ICollection<DryCargo_City> DryCargo_Cities { get; set; }
        public ICollection<DCExpense> DCExpenses { get; set; } = new List<DCExpense>();

        public DryCargo()
        {
        }

        public DryCargo(int id, double value, double totalKM, string material, DateTime departureDate, DateTime arrivalDate, ShippingCompany shippingCompany)
        {
            Id = id;
            Value = value;
            TotalKM = totalKM;
            Material = material;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            ShippingCompany = shippingCompany;
        }

        public void AddDCExpense(DCExpense expense)
        {
            DCExpenses.Add(expense);
        }

        public void RemoveDCExpense(DCExpense expense)
        {
            DCExpenses.Remove(expense);
        }

        public double TotalDCExpenses(DateTime initial, DateTime final)
        {
            return DCExpenses.Where(expense => expense.Date >= initial && expense.Date <= final).Sum(expense => expense.Value);
        }
    }
}

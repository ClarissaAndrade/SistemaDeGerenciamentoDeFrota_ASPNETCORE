using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SGF.Models
{
    public class SGFContext : DbContext
    {
        public SGFContext(DbContextOptions<SGFContext> options)
            : base(options)
        {
        }

        public DbSet<DCExpense> DCExpense { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<DCExpenseType> DCExpenseType { get; set; }
        public DbSet<DryCargo> DryCargo { get; set; }
        public DbSet<ShippingCompany> ShippingCompany { get; set; }
    }
}
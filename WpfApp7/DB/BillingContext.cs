using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WpfApp7.DB
{
    public class BillingContext : DbContext
    {
        public DbSet<account> Acoounts { get; set; } 
        public DbSet<Bill> Bills { get; set; }

        public BillingContext()
        {
            
        }
            

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=admin;Password=root;Host=192.168.50.194;Port=6000;Database=lulavdan;");
        }
    }
}

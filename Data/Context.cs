using CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Data
{
    internal class Context : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<RentalOffice> RentalOffices { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                    Server=localhost; 
                    Database=CarRental; 
                    Trusted_Connection=True; 
                    Trust Server Certificate=Yes; 
                    User Id=CarRental; 
                    password=CarRental");
        }
    }
}

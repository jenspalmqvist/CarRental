using CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Data
{
    // Context is our connection to the database specified in the connection string
    // which we find later in this file, it inherits DbContext which
    // comes from Entity Framework. Ít contains all the tools we need to 
    // communicate with our database.
    internal class Context : DbContext
    {
        // Our DbSet properties tells the context ( which talks to the database)
        // which tables exist, DbSet is a type which comes from Entity Framework
        // and defines a tables structure from the class we specify 
        public DbSet<Car> Cars { get; set; }
        public DbSet<RentalOffice> RentalOffices { get; set; }
        public DbSet<Customer> Customers { get; set; }


        // This method is executed when we create a new Context object
        // the optionsBuilder.UseSqlServer-method tells the Context which
        // database it should connect to
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

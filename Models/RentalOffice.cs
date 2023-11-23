

namespace CarRental.Models
{
    internal class RentalOffice
    {
        public Guid Id { get; set; }
        public string OfficeName { get; set; }

        // ICollection is a datatype that makes Entity Framework understand the relation between the tables
        // In this case, RentalOffice has a ICollection of Cars, while Car only has one RentalOffice,
        // That makes this a One-To-Many relation
        public ICollection<Car> Cars { get; set; } = new List<Car>();

        // In this case, RentalOffice has an ICollection of Customers, and Customer has an ICollection of RentalOffices
        // That makes this a Many-To-Many relation. Entity Framework will create the junction table "CustomerRentalOffice" for us
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();

        // If we create a new RentalOffice with new Cars and new Customers, we only need to add the RentalOffice to the context,
        // the connected Cars and Customers will be added to the database at the same time.

        public RentalOffice()
        {

        }
    }
}



namespace CarRental.Models
{
    internal class RentalOffice
    {
        public Guid Id { get; set; }
        public string OfficeName { get; set; }
        public ICollection<Car> Cars { get; set; } = new List<Car>();
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();

        public RentalOffice()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CarId { get; set; }
        public Car? Car { get; set; } = null;
        public ICollection<RentalOffice> RentalOffices { get; set; } = new List<RentalOffice>();
    }
}

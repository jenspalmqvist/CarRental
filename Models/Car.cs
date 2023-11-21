using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    internal class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public int DailyRate { get; set; }
        public RentalOffice RentalOffice { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Car()
        {

        }
    }
}

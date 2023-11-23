using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    internal class Car
    {
        public int Id { get; set; }


        // Attributes modify the expected behaviour of the column in the database, 
        // They affect the property below the Attribute tag
        // This Attribute ([StringLength(25)] sets the maximum length for Manufacturer to 25.
        [StringLength(25)]
        public string Manufacturer { get; set; }

        [StringLength(40)]
        public string Model { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public int DailyRate { get; set; }
        public RentalOffice RentalOffice { get; set; }

        // The question mark makes this field nullable in the database
        public Customer? Customer { get; set; } = null;
        public bool IsAvailable { get; set; } = true;

        public Car()
        {

        }
    }
}

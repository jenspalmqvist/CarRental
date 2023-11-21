using CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Data
{
    internal class DataAccess
    {

        public void Seed()
        {
            Context context = new Context();
            Car car1 = new();
            car1.Manufacturer = "Volvo";
            car1.Model = "840";
            car1.Color = "Red";
            car1.Mileage = 123597;
            car1.DailyRate = 1000;
            Car car2 = new();
            car2.Manufacturer = "Saab";
            car2.Model = "90000";
            car2.Color = "Blue";
            car2.Mileage = 1235999;
            car2.DailyRate = 100;
            Car car3 = new();
            car3.Manufacturer = "Volvo";
            car3.Model = "740";
            car3.Color = "Brown";
            car3.Mileage = 123599900;
            car3.DailyRate = 10;
            RentalOffice office1 = new RentalOffice();
            office1.OfficeName = "Stockholm";
            RentalOffice office2 = new RentalOffice();
            office2.OfficeName = "Sveg";
            Customer customer1 = new Customer();
            customer1.FirstName = "Jens";
            customer1.LastName = "Palmqvist";
            Customer customer2 = new Customer();
            customer2.FirstName = "Benny";
            customer2.LastName = "Andersson";

            office1.Cars = new List<Car>() { car1, car2 };
            office1.Customers = new List<Customer>() { customer1, customer2 };
            office2.Cars = new List<Car>() { car3 };
            office2.Customers = new List<Customer>() { customer2 };

            context.RentalOffices.AddRange(new List<RentalOffice>() { office1, office2 });
            context.SaveChanges();
        }

        public void GetFirstCar()
        {
            Context context = new Context();
            var car = context.Cars.Include(car => car.RentalOffice).ThenInclude(office => office.Customers).First();
            Console.WriteLine($"Model: {car.Model}, Office: {car.RentalOffice.OfficeName}, Customers: {car.RentalOffice.Customers.ToArray()[0].FirstName}");
        }
    }
}

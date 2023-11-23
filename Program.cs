using CarRental.Data;
using CarRental.Models;

namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataAccess dataAccess = new DataAccess();
            //dataAccess.GetFirstCar();
            //dataAccess.CreateCar();
            //Car? foundCar = dataAccess.GetFirstCarByModel("Duster2");
            //if (foundCar == null)
            //{
            //    Console.WriteLine("Car with model not found");
            //}
            //else
            //{
            //    Console.WriteLine(foundCar.Manufacturer);
            //}
            //dataAccess.GetCarsAndCustomersInOffice();
            //dataAccess.Seed();
            dataAccess.RentCarWithId(2, 1);

        }
    }
}

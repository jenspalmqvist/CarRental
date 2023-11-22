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
            Car foundCar = dataAccess.GetFirstCarByModel("Duster2");
            Console.WriteLine(foundCar.Manufacturer);
            //dataAccess.Seed();
        }
    }
}

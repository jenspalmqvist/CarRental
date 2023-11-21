using CarRental.Data;

namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataAccess dataAccess = new DataAccess();
            dataAccess.GetFirstCar();
            //dataAccess.Seed();
        }
    }
}

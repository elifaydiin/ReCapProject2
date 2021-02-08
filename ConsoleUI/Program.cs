using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarsBrandId();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.CarName}");
            }
        }

        private static void GetCarsBrandId()
        {
            //IOC
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}

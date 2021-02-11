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
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarName}/{car.ColorName}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        //private static void GetCarsBrandId()
        //{
        //    //IOC
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarsByBrandId(2))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        }
    }


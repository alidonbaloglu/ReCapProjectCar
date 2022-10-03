using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entitiess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarEkleTest();

            //ColorEkleTest();

            //BrandTest();

            //ColorTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araba Adı: {0} / Marka Adı: {1} / Araba Rangi: {2} / Araba Fiyatı: {3}",
                    car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorEkleTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 12, Name = "Gökkuşağı Mavisi" });
            foreach (var color in colorManager.GetCarsByColorId(12))
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void CarEkleTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 55, BrandId = 5, Description = "Mercedes", ColorId = 1, DailyPrice = 1200, ModelYear = 2008 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
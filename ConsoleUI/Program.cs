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
            CarManager carManager = new CarManager( new EfCarDal());
            carManager.Add(new Car { Id = 5, BrandId = 5, Description = "Mercedes", ColorId = 1, DailyPrice = 0, ModelYear = 2008 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetCarsByColorId(2))
            {
                Console.WriteLine(color.Name);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(brand.Name);

            }
        }
    }
}
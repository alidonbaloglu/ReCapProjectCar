using DataAccess.Abstract;
using Entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2001,Description="Toyota",DailyPrice=100},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2022,Description="Passat",DailyPrice=2500},
                new Car{Id=3,BrandId=3,ColorId=1,ModelYear=2013,Description="Honda",DailyPrice=300},
                new Car{Id=4,BrandId=4,ColorId=3,ModelYear=2019,Description="Golf",DailyPrice=500},
                new Car{Id=5,BrandId=5,ColorId=2,ModelYear=1998,Description="Şahin",DailyPrice=20}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id==Id).ToList();

        }

        

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id=car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;    
            carToUpdate.ModelYear=car.ModelYear;    
            carToUpdate.Description=car.Description;
            carToUpdate.DailyPrice=car.DailyPrice;


        }
    }
}

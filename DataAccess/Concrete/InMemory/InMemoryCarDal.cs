using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2018,DailyPrice=500000,Description="Audi"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=400000,Description="Audi"},
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=100000,Description="Opel"},
                new Car{Id=4,BrandId=2,ColorId=1,ModelYear=2009,DailyPrice=95000,Description="Opel"},
                new Car{Id=5,BrandId=3,ColorId=1,ModelYear=2000,DailyPrice=50000,Description="Fiat"},
                new Car{Id=6,BrandId=4,ColorId=1,ModelYear=2020,DailyPrice=1000000,Description="BMW"},
                new Car{Id=7,BrandId=4,ColorId=1,ModelYear=2007,DailyPrice=100000,Description="BMW"},
                new Car{Id=8,BrandId=3,ColorId=1,ModelYear=2012,DailyPrice=120000,Description="Fiat"},
            };
        }
        public void Add(Car car)
        {
            
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //linq used for to delete 
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id==carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}

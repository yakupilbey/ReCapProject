using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //Database Connection Simulation
            _cars = new List<Car> {
                new Car{Id =1, BrandId =2, ColorId= 3, ModelYear = 2013, DailyPrice =49, Description = "Mercedes Benz"},
                new Car{Id =2, BrandId =2, ColorId= 3, ModelYear = 2014, DailyPrice =65, Description = "Kia"},
                new Car{Id =3, BrandId =2, ColorId= 3, ModelYear = 2015, DailyPrice =77, Description = "BMW" },
                new Car{Id =4, BrandId =2, ColorId= 3, ModelYear = 2016, DailyPrice =89, Description = "Audi" },
                new Car{Id =5, BrandId =2, ColorId= 3, ModelYear = 2017, DailyPrice =137, Description = "Porsche" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Using LINQ
            Car carToDelete = _cars.SingleOrDefault(p=>p.BrandId == car.BrandId);
            _cars.Remove(carToDelete);
        }

        

        public List<Car> GettAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            //Using LINQ
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul.
            Car carToUpdate = _cars.SingleOrDefault(p => p.BrandId == car.BrandId);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GettAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}

using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetsCarsByColorId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByModelYear(int id);
        List<CarDetailDto> GetCarDetails();
    }
}



//public int Id { get; set; }
//public int BrandId { get; set; }
//public string Name { get; set; }
//public int ColorId { get; set; }
//public int ModelYear { get; set; }
//public int DailyPrice { get; set; }

//UNUTMA Refactoring
//IDataResult<List<Car>> GetAll();
//IDataResult<Car> GetById(int id);
//IDataResult<List<CarDetailDto>> GetCarDetails();
//IDataResult<List<CarDetailDto>> GetCarsByBrandId(int p);
//IDataResult<List<CarDetailDto>> GetCarsByColorId(int p);
//IResult Update(Car car);
//IResult Delete(Car car);
//IResult Add(Car car);
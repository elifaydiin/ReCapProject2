using Business.Abstarct;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            if (car.Description.Length < 2)
            {
                return new ErrorResult();
            }
            return new SuccessResult(Messages.CarAdded);//tip dönüşümlerini ctor ile yapıcagız.
        }
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>>GetCarDetails()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return  new SuccessDataResult<List<Car>> (_carDal.GetAll(c => c.ColorId == id));
        }

      
    }
}




//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DataAccess.Concrete
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;//global değişken

//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car{Id=1,BrandId=5,ColorId=9,ModelYear="2010",DailyPrice=100000,Description="BMW"},
//                new Car{Id=2,BrandId=6,ColorId=10,ModelYear="2015",DailyPrice=150000,Description="Toyota"},
//                new Car{Id=3,BrandId=7,ColorId=11,ModelYear="2016",DailyPrice=250000,Description="Mercedes"},
//                new Car{Id=4,BrandId=8,ColorId=12,ModelYear="2003",DailyPrice=175000,Description="Opel"},
//            };
//        }

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car deletoToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
//            _cars.Remove(deletoToCar);
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }


//        public void Update(Car car)
//        {
//            Car updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
//            updateToCar.ModelYear = car.ModelYear;
//            updateToCar.Id = car.Id;
//            updateToCar.DailyPrice = car.DailyPrice;
//            updateToCar.Description = car.Description;
//            updateToCar.ColorId = car.ColorId;
//            updateToCar.BrandId = car.BrandId;

//        }

//        public List<Car> GetById(int id)
//        {
//            return _cars.Where(c => c.Id == id).ToList();
//        }
//    }
//}

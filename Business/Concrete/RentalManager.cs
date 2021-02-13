using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

       

        public IResult Add(Rental rental)
        {
           
            var result = CheckReturnDate(rental.CarId);
            if (!result.Success)
            {
                return new ErrorResult(Messages.RentError);
            }
            _rentalDal.Add(rental);
            return new SuccessDataResult<List<Rental>>(Messages.RentAdded);
        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.GetRentalDetail(x => x.CarId == carId && x.ReturnDate == null);
            if (result.Count>0)
            {
                return new ErrorResult(Messages.RentError);
            }
            return new SuccessResult(Messages.RentAdded);

        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());

        }

        public IDataResult<List<RentDetailDto>> GetRentalDetails(int carId)
        {
            return new SuccessDataResult<List<RentDetailDto>>(_rentalDal.GetRentalDetail(x => x.CarId == carId));
        }

        public IResult UpdateReturnDate(int carId)
        {
            var result = _rentalDal.GetAll(x => x.CarId== carId);
            var updatedRental = result.LastOrDefault();
            if (updatedRental.ReturnDate != null)
            {
                return new ErrorResult();
            }
            updatedRental.ReturnDate = DateTime.Now;
            _rentalDal.Update(updatedRental);
            return new SuccessResult();
        }

    }
}

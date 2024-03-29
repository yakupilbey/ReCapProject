﻿using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
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

        [ValidationAspect(typeof(RentalValidator))]
        public IDataResult<Rental> Add(Rental rental)
        {
            var result = BusinessRules.Run(ReturnDateCheck(rental.CarId, rental.RentDate));
            if (result != null)
            {
                return new ErrorDataResult<Rental>(result.Message);
            }
            _rentalDal.Add(rental);
            return new SuccessDataResult<Rental>(rental);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }


        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        // Business Rules

        private IResult ReturnDateCheck(int carId, DateTime rentDate)
        {
            var rentals = _rentalDal.GetRentalDetails(p => p.CarId == carId);

            foreach (var item in rentals)
            {
                if (rentDate < item.ReturnDate)
                {
                    return new ErrorResult();
                }
            }

            return new SuccessResult();
        }

    }
}

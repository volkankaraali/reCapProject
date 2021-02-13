using Business.Abstract;
using Business.Constants;
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
        public IResult Add(Rental rental)
        {
            var customerCheck = _rentalDal.GetAll(p=>p.CustomerId==rental.CustomerId);
            
            if (customerCheck.Count>0)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }
            else
            {
                _rentalDal.Add(rental);
                 return new SuccessResult(Messages.RentalAddedSuccess);
            }
            


        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeletedSuccess);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalGetAllSuccess);
        }

        public IDataResult<List<RentDetailDto>> GetRentDetails()
        {
            return new SuccessDataResult<List<RentDetailDto>>(_rentalDal.GetRentDetails(),Messages.RentalGetAllSuccess);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdatedSuccess);
        }
    }
}

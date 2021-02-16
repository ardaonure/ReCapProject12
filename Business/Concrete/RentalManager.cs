using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class RentalManager: IRentalService
   {
       private IRentalDal _rentalDal;

       public RentalManager(IRentalDal rentalDal)
       {
           _rentalDal = rentalDal;
       }



       public IDataResult<List<Rental>> GetAll()
       {
           return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);

       }

       public IDataResult<Rental> GetCarsById(int id)
       {
           return new SuccessDataResult<Rental>(_rentalDal.GetById(r => r.Id == id));
       }

       public IResult Add(Rental entity)
       {
           var a = entity.RentDate;
           if (a==null)
           {
               return new ErrorResult<Rental>(Messages.RentDateError);
           }
           _rentalDal.Add(entity);
           return new SuccessResult<Rental>();
       }

       public IResult Update(Rental entity)
       {
           _rentalDal.Update(entity);
           return new SuccessResult<Rental>();
       }

       public IResult Delete(Rental entity)
       {
           _rentalDal.Delete(entity);
           return new SuccessResult<Rental>();
       }
        
    }
}

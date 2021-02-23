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
   public class BrandManager:IBrandService
   {
       private IBrandDal _brandDal;

       public BrandManager(IBrandDal brandDal)
       {
           _brandDal = brandDal;
       }

       public IDataResult<List<Brand>> GetAll()
       {
           return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.Listed);

       }

       public IDataResult<Brand> GetCarsById(int id)
       {
           return new SuccessDataResult<Brand>(_brandDal.GetById(b => b.BrandId == id));
       }

       public IResult Add(Brand entity)
       {
           if (DateTime.Now.Hour==23)
           {
               return new ErrorResult();
           }
           _brandDal.Add(entity);
           return new SuccessResult();
        }

       public IResult Update(Brand entity)
       {
           _brandDal.Update(entity);
           return new SuccessResult();
        }

       public IResult Delete(Brand entity)
       {
           _brandDal.Delete(entity);
           return new SuccessResult();
        }

       
   }
}

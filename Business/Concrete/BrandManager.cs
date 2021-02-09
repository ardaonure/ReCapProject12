using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class BrandManager:IBrandManager
   {
       private IBrandDal _brandDal;

       public BrandManager(IBrandDal brandDal)
       {
           _brandDal = brandDal;
       }

       public List<Brand> GetAll()
       {
           return _brandDal.GetAll();
       }

       public Brand GetCarsById(int id)
       {
           return _brandDal.GetById(b => b.BrandId == id);
       }

       public void Add(Brand entity)
       {
           _brandDal.Add(entity);
       }

       public void Update(Brand entity)
       {
           _brandDal.Update(entity);
        }

       public void Delete(Brand entity)
       {
           _brandDal.Delete(entity);
        }

       
   }
}

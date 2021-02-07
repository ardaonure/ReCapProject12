﻿using System;
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

       public Brand GetCarsByBrandId(int brandId)
       {
           return _brandDal.GetById(b=>b.BrandId==brandId);
       }
    }
}
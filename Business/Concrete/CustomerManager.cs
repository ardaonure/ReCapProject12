﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
  public  class CustomerManager:ICustomerService
  {
      private ICustomerDal _customerDal;

      public CustomerManager(ICustomerDal customerDal)
      {
          _customerDal = customerDal;
      }


      public IDataResult<List<Customer>> GetAll()
      {
          return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.Listed);

      }

      public IDataResult<Customer> GetCarsById(int id)
      {
          return new SuccessDataResult<Customer>(_customerDal.GetById(c => c.UserId == id));
      }

      public IResult Add(Customer entity)
      {

          _customerDal.Add(entity);
          return new SuccessResult();
        }

      public IResult Update(Customer entity)
      {
          _customerDal.Update(entity);
          return new SuccessResult();
        }

      public IResult Delete(Customer entity)
      {
          _customerDal.Delete(entity);
          return new SuccessResult();
        }


     
    }
}

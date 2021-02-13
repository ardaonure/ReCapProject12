using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

      public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetCarsById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            _customerDal.Add(entity);
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}

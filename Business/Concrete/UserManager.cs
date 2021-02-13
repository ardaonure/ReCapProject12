using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
  public  class UserManager:IUserService
    {
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetCarsById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}

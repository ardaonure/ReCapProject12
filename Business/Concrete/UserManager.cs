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
  public  class UserManager:IUserService
  {
      private IUserDal _userDal;

      public UserManager(IUserDal userDal)
      {
          _userDal = userDal;
      }


      public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);

        }

        public IDataResult<User> GetCarsById(int id)
        {
            return new SuccessDataResult<User>(_userDal.GetById(u=>u.Id==id));
        }

        public IResult Add(User entity)
        {

            _userDal.Add(entity);
            return new SuccessResult<User>();
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult<User>();
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult<User>();
        }
    }
}

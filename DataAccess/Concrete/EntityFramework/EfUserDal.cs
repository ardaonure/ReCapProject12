﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfUserDal:EfEntityRepositoryBase<User, CarRentalDbContext>,IUserDal
    {
    }
}

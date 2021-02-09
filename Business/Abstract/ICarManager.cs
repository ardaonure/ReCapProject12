using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
  public  interface ICarManager:IDataAccessRepository<Car>
  {
      List<CarDetailDto> GetCarDetails();
  }
}

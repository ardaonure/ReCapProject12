using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Business
{
  public  interface IDataAccessRepository<T>
    {
       IDataResult<List<T>> GetAll();
       IDataResult<T> GetCarsById(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}

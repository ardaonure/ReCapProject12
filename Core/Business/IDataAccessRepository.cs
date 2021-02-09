using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business
{
  public  interface IDataAccessRepository<T>
    {
        List<T> GetAll();
        T GetCarsById(int Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

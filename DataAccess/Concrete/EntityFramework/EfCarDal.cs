using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalDbContext context=new CarRentalDbContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.Id equals b.BrandId
                        join co in context.Colors
                            on c.Id equals co.ColorId
                    select new CarDetailDto
                    {
                        Name = c.Name,
                        BrandName = b.BrandName,
                        ColorName = co.ColorName,
                        DailyPrice = c.DailyPrice,
                    };
                return result.ToList();
                
            }
        }
    }
}

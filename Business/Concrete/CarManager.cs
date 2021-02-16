using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);

        }

        public IDataResult<Car> GetCarsById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(c => c.Id == id));
        }

        public IResult Add(Car entity)
        {
            var a = entity.ToString();
            var b = entity.DailyPrice;
            
            if (a.Length<2 && b<0)
            {
                return new ErrorResult<Car>();
            }
            _carDal.Add(entity);
            return new SuccessResult<Car>();
        }

        public IResult Update(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult<Car>();
        }

        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult<Car>();
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}

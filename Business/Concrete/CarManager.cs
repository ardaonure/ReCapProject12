using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarManager
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetCarsByCarId(int carId)
        {
            return _carDal.GetById(p => p.Id == carId);
        }

        public void Add(Car car)
        {
            string a = car.Name;
            var b = car.DailyPrice;
            if (a.Length>2 && b>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Hatalı giriş! İsim 2 harften, günlük ücret 0 dan büyük olmalı!");
            }

            
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}

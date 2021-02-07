using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandManager brandManager = new BrandManager(new EfBrandDal());


            //foreach (var a in brandManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(a.BrandName);
            //}



            //CarManager carManager = new CarManager(new EfCarDal());

            //var b = carManager.GetCarsByCarId(2);
            //Console.WriteLine(b.Name);


           

            CarManager carManager=new CarManager(new EfCarDal());
            //carManager.Add(new Car
            //{
            //    Name = "To",
            //    ModelYear = 2019,
            //    DailyPrice = 220,
            //    Description = "Süper"
            //});
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }


            //ColorManager colorManager=new ColorManager(new EfColorDal());
            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.ColorName);
            //}



            //ColorManager colorManager=new ColorManager(new EfColorDal());

            //foreach (var item in colorManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(item);
            //}


            Console.ReadLine();
        }
    }
}

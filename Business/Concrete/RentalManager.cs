using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class RentalManager: IRentalService
   {
       private IRentalDal _rentalDal;

       public RentalManager(IRentalDal rentalDal)
       {
           _rentalDal = rentalDal;
       }

       public List<Rental> GetAll()
       {
          return _rentalDal.GetAll();
       }

        public Rental GetCarsById(int id)
        {
            return _rentalDal.GetById(r=>r.Id==id);
        }

        public void Add(Rental entity)
        {
            Rental rental=new Rental();
            if (rental.RentDate!=null)
            {
                _rentalDal.Add(entity);
            }
            else
            {
                Console.WriteLine("Arabanın kiralanması için teslim edilmesi gerekir.");
            }
            
        }

        public void Update(Rental entity)
        {
            
        }

        public void Delete(Rental entity)
        {
            
        }
    }
}

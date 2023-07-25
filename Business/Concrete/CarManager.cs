using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager :ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Islem tamamlandi.");
            }
            else
            {
                Console.WriteLine("Araç ismi minimum iki karakter ve günlük fiyat 0'dan büyük olmalıdır");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GateById(int Id)
        {
            return _carDal.Get(c => c.Id == Id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(p => p.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(p => p.ColorId == ColorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}

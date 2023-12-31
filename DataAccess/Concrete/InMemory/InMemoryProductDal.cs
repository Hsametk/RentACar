﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal  : ICarDal
    {
        List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,ModelYear = 2023,DailyPrice = 25000,Description = "Tesla"},
                new Car{Id = 2,BrandId = 2,ColorId = 2,ModelYear = 2023,DailyPrice = 25000,Description = "Bmw"},
                new Car{Id = 3,BrandId = 1,ColorId = 1,ModelYear = 2023,DailyPrice = 25000,Description = "Mercedes"},
                new Car{Id = 4,BrandId = 3,ColorId = 3,ModelYear = 2023,DailyPrice = 25000,Description = "Fiat"},
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id) 
        { 
            return _cars.Where(c => c.Id == Id).ToList();

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}

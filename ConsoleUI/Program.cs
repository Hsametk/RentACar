// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

 void BrandManagerTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());

    //foreach (var brand in brandManager.GetAll())
    //{
    //    Console.WriteLine(brand.Id + "--" + brand.Name);
    //}

    Console.WriteLine("GetById");
    var get = brandManager.GetById(2);
    Console.WriteLine(get.Id + "--" + get.Name);
    Console.WriteLine("GetById");

}

//BrandManagerTest();
void ColorManagerTest()
{
    ColorManager colorManager = new ColorManager(new EfColorsDal());

    foreach (var color in colorManager.GetAll())
    {
        Console.WriteLine(color.Id + "--" + color.Name);
    }

}

//ColorManagerTest();
void CarManagerTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

//carManager.Add(new Car() { BrandId = 1, ColorId = 3, Description = "Mercedes", DailyPrice = 1000, ModelYear = 2023 });
//carManager.Add(new Car() { BrandId = 7, ColorId = 4, Description = "Peugeot", DailyPrice = 50, ModelYear = 2021 });
//carManager.Add(new Car() { BrandId = 9, ColorId = 5, Description = "H", DailyPrice = 60, ModelYear = 2022 });
//carManager.Add(new Car() { BrandId = 8, ColorId = 5, Description = "Toyota", DailyPrice = 60, ModelYear = 2022 });
//carManager.Add(new Car() { BrandId = 9, ColorId = 2, Description = "Honda", DailyPrice = 0, ModelYear = 2022 });

    foreach (var car in carManager.GetAll())
    {
        Console.WriteLine();
    }

    //Console.WriteLine("-------------------");
    //foreach (var car in carManager.GetCarsByBrandId(4))
    //{
    //    Console.WriteLine(car.BrandId + " " + car.Description);
    //}

    //Console.WriteLine("-------------------");
    //foreach (var car in carManager.GetCarsByColorId(3))
    //{
    //    Console.WriteLine(car.ColorId + " " + car.Description);
    //}
}

//CarManagerTest();
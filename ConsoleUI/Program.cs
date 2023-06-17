// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryProductDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

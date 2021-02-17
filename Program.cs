using CarRentalProject.Business.Concrete;
using CarRentalProject.DataAccess.Concrete;
using System;

namespace CarRentalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new InMemoryCarDal());
            Console.WriteLine("------------Ürünler----------");
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine("CarId: {0} Description: {1}  ModelYear:{2} DailyPrice: {3}",
                    car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Filtre Sonucu: {0} {1}", carManager1.GetById(1).CarId, carManager1.GetById(1).DailyPrice);
        }
    }
}

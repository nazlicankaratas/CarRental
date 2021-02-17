using CarRentalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.Business.Abstruct
{
   public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);
    }
}

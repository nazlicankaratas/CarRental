using CarRentalProject.Business.Abstruct;
using CarRentalProject.DataAccess.Abstruct;
using CarRentalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.Business.Concrete
{
    class CarManager : ICarService
    {

        ICarDal _iCarDal; // Veri erişim yöntemlerinin her birini tutabilecek referans
        public CarManager(ICarDal iCarDal)
        { // Oluşturma anında bir veri erişim yöntemi istiyor.
            _iCarDal = iCarDal;
        }


        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _iCarDal.GetCarById(carId);

        }
    }
}

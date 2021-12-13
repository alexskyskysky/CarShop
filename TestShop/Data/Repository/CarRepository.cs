using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository {
    public class CarRepository : IAllCars {
        private readonly AppDBContent _appDbContent;

        public CarRepository(AppDBContent appDbContent) {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars => _appDbContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => _appDbContent.Car.Where(f => f.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) {
            return _appDbContent.Car.FirstOrDefault(c => c.id == carId);
        }
    }
}
﻿using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Repository {

    public class CarRepository : IAllCars {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(f => f.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(c => c.id == carId);
    }
}
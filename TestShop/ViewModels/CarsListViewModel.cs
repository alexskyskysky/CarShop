﻿using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.ViewModels {
    public class CarsListViewModel {
        public IEnumerable<Car> allCars { get; set; }
        public string currentCategory { get; set; }
    }
}
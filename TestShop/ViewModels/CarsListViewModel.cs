﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Data.Models;

namespace TestShop.ViewModels {
    public class CarsListViewModel {
        public IEnumerable<Car> allCars { get; set; }
        public string currentCategory { get; set; }
    }
}

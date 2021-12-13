using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers {
    public class CarsController : Controller {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCatergories) {
            _allCars = iAllCars;
            _allCategories = iCarsCatergories;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category) {
            IEnumerable<Car> cars = null;
            var currCategory = "";
            if (string.IsNullOrEmpty(category)) {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else {
                if (string.Equals("Electro", category, StringComparison.OrdinalIgnoreCase)) {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName == "Электромобили").OrderBy(i => i.id);
                    currCategory = "Электромобили";
                }

                if (string.Equals("Fuel", category, StringComparison.OrdinalIgnoreCase)) {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName == "Классические автомобили")
                        .OrderBy(i => i.id);
                    currCategory = "Классические автомобили";
                }
            }

            var carObj = new CarsListViewModel {
                allCars = cars,
                currentCategory = currCategory
            };
            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);
        }
    }
}
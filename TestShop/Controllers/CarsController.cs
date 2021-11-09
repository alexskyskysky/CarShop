using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Data.Interfaces;
using TestShop.ViewModels;

namespace TestShop.Controllers {
    public class CarsController : Controller {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCatergories) {
            _allCars = iAllCars;
            _allCategories = iCarsCatergories;
        }

        public ViewResult List() {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currentCategory = "Автомобили";
            return View(obj);
        }
    }
}

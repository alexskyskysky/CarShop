using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks {
    public class MockCategory : ICarsCategory {
        public IEnumerable<Category> AllCategories =>
            new List<Category> {
                new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                new Category
                    { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
            };
    }
}
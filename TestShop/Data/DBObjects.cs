using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Shop.Data.Models;

namespace Shop.Data {
    public class DBObjects {
        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories {
            get {
                if (category == null) {
                    var list = new[] {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category {
                            categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"
                        }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (var el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }

        public static void Initial(AppDBContent content) {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.Car.AddRange(
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый электромобиль",
                        longDesc = "Красивый, быстрый и ультрасовременный автомобиль от компании Tesla",
                        img = "/img/tesla_model_s.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/ford_fiesta.jpg",
                        price = 15000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/bmw_m3.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        name = "Mercedes C Class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Роскошь и уют",
                        img = "/img/mercedes_c_class.jpg",
                        price = 50000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Надежный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan_leaf.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                );

            content.SaveChanges();
        }
    }
}
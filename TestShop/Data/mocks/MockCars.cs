using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Data.Interfaces;
using TestShop.Data.Models;

namespace TestShop.Data.mocks {
    public class MockCars : IAllCars {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car { 
                        name="Tesla Model S", 
                        shortDesc="Быстрый электромобиль", 
                        longDesc="Красивый, быстрый и ультрасовременный автомобиль от компании Tesla", 
                        img="/img/tesla_model_s.jpg", 
                        price=45000, 
                        isFavourite=true, 
                        available=true, 
                        Category=_categoryCars.AllCategories.First() 
                    },
                    new Car {
                        name="Ford Fiesta",
                        shortDesc="Тихий и спокойный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/ford_fiesta.jpg",
                        price=15000,
                        isFavourite=false,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name="BMW M3",
                        shortDesc="Дерзкий и стильный",
                        longDesc="Удобный автомобиль для городский жизни",
                        img="/img/bmw_m3.jpg",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name="Mercedes C Class",
                        shortDesc="Уютный и большой",
                        longDesc="Роскошь и уют",
                        img="/img/mercedes_c_class.jpg",
                        price=50000,
                        isFavourite=false,
                        available=false,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name="Nissan Leaf",
                        shortDesc="Надежный и экономный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/nissan_leaf.jpg",
                        price=14000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId) {
            throw new NotImplementedException();
        }
    }
}

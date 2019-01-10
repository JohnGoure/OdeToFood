using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Services {
    class InMemoryRestaurantData : IRestaurantData {
        

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant> {
                new Restaurant { ID = 1, Name = "Pizza Hut"},
                new Restaurant { ID = 2, Name = "Taco Bell"},
                new Restaurant { ID = 3, Name = "Chick Fila"}
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return this._restaurants;
        }

        private List<Restaurant> _restaurants;
    }
}
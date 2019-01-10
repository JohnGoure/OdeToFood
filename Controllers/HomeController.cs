using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers {

    public class HomeController : Controller {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            this._restaurantData = restaurantData;
        }
        
        public IActionResult Index() {
            var model = this._restaurantData.GetAll();
            return View(model);
        }
    }
}
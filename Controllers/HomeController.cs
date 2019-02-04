using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers {

    public class HomeController : Controller {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _greeter = greeter;
            _restaurantData = restaurantData;
        }
        
        public IActionResult Index() 
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }

        public IActionResult Details(int id) 
        {
            var model = _restaurantData.Get(id);
            if (model == null) {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
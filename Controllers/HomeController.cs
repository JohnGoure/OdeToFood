using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers {

    public class HomeController : Controller {
        public IActionResult Index() {
            var model = new Restraunt {
                ID = 1,
                Name = "Pizza Hut"
            };
            return View(model);
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers {

    [Route("[controller]")]
    public class AboutController : Controller {
        
        [Route("")]
        public string Phone() {
            return "210-459-8845";
        }

        [Route("address")]
        public string Address() {
            return "San Antonio, Tx";
        }
    }
}
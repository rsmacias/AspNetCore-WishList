using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers {
    public class HomeController: Controller {
        public HomeController() {
            
        }

        public IActionResult Index() {
            return View("Index");
        }

        public IActionResult Error() {
            return View("Error");
        }
    }
}
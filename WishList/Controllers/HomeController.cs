using Microsoft.AspNetCore.Mvc;

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
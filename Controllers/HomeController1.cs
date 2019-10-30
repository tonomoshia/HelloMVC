using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HomeController1 : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
}

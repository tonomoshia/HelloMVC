using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string name = "World")
        {
            //if (string.IsNullOrEmpty(name))
            //{
            //    name = "World";
            //}

            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/HTML");
        }
        // used https://localhost:44350/Hello?name=Lola to test query parameter
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<form method='post' action='/Hello/Display'>" +
                "<input type='text' name = 'name'  />" +
                 "<input type='submit' value='Greet me!'  />" +
                "</form>";

            return Content(html, "text/HTML");
        }
        // used https://localhost:44350/Hello?name=Lola to test query parameter

        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/HTML");
        }
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}

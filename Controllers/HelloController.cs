using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //customize route so post request goes to same page (Hello) post data to same url
            string html = "<form method='post'>" +
                "<input type='text' name = 'name'  />" +
                 "<input type='submit' value='Greet me!'  />" +
                "</form>";

            return Content(html, "text/HTML");
        }
        // used https://localhost:44350/Hello?name=Lola to test query parameter

        //Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/HTML");
        }

        // Handle request to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/HTML");
        }
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}

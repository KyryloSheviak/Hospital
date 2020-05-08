using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("contacts")]
        public IActionResult Contacts()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}

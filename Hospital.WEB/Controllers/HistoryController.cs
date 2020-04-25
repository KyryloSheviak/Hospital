using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult History()
        {
            return View();
        }
    }
}
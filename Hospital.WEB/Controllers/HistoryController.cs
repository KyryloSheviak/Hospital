using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("history")]
    public class HistoryController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
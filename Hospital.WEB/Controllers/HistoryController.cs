using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("history")]
    public class HistoryController : Controller
    {
        public IActionResult History()
        {
            return View();
        }

        public IActionResult GetAllHistories() { return NotFound(); }

        // получение истории юзера
        public  IActionResult GetUserHistory()
        {
            return NotFound();
        }


        public IActionResult AddAnalyzesToUser()
        {
            return NotFound();
        }

        public IActionResult DownloadUserHistory()
        {
            return NotFound();
        }

        public IActionResult DownloadUserAnalyzes()
        {
            return NotFound();
        }
    }
}
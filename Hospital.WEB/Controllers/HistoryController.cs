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

        // получение истории юзера
        public  IActionResult GetUserHistory()
        {
            return null;
        }


        public IActionResult AddAnalyzesToUser()
        {
            return null;
        }

        public IActionResult DownloadUserHistory()
        {
            return null;
        }

        public IActionResult DownloadUserAnalyzes()
        {
            return null;
        }
    }
}
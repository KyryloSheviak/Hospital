using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    public class WorkDayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ApproveWorkDay() { return NotFound(); }
        public IActionResult CancelWorkDay() { return NotFound(); }
        public IActionResult UpdateWorkDay() { return NotFound(); }

        public IActionResult GetWorkDayByFIO() { return NotFound(); }
        public IActionResult GetWorkDayByEmail() { return NotFound(); }
        public IActionResult GetWorkDayByPhone() { return NotFound(); }

        public IActionResult GetAllWorkDays() { return NotFound(); }
    }
}
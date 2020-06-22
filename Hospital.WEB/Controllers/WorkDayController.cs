using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("admin")]
    //[Authorize(Roles = "admin")]
    public class WorkDayController : Controller
    {
        [Route("test123")]
        public IActionResult ApproveWorkDay() { return NotFound(); }
        [Route("test124")]
        public IActionResult CancelWorkDay() { return NotFound(); }
        [Route("test125")]
        public IActionResult UpdateWorkDay() { return NotFound(); }
        [Route("test126")]
        public IActionResult GetWorkDayByFiled() { return NotFound(); }
        
        [Route("work-days")]
        public IActionResult GetAllWorkDays() { return View(); }
    }
}
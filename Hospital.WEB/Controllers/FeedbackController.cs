using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllFeedbacks() { return NotFound(); }

        public IActionResult CreateFeedback()
        {
            return NotFound();
        }

        public IActionResult UpdateFeedback()
        {
            return NotFound();
        }
    }
}
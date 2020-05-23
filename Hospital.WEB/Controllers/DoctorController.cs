using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("doctor")]
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("work-days")]
        public IActionResult AddWorkDays() { return View(); }
        public IActionResult UpdateReception() { return null; }
        public IActionResult GetInfoByUser() { return null; }
        public IActionResult GetReviews() { return null; }
    }
}
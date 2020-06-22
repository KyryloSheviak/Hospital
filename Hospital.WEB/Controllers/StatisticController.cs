using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("statistic")]
    [Authorize(Roles = "doctor, admin")]
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("doctor")]
        public IActionResult GetStatisticForDoctor() { return null; }

        [Route("admin")]
        public IActionResult GetStatisticForAdmin() { return View(); }
    }
}

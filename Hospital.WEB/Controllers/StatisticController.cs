using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStatisticForDoctor() { return null; }
        public IActionResult GetStatisticForAdmin() { return null; }
    }
}

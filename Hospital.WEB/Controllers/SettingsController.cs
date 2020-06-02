using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpdateUserInfo() { return NoContent(); }
        public IActionResult ResetPassword() { return NoContent(); }
        public IActionResult UpdatePhoto() { return NoContent(); }
        public IActionResult DeletePhoto() { return NoContent(); }
    }
}

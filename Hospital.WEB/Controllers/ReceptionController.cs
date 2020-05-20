using Hospital.BL.DTO;
using Hospital.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    public class ReceptionController : Controller
    {
        [HttpPost]
        public IActionResult Create(ReceptionViewModel reception)
        {
            return View();
        }

       public IActionResult GetAllReceptions() { return null; }
       public IActionResult InsertReception() { return null; }
       public IActionResult UpdateReception() { return null; }
       public IActionResult DeleteReception() { return null; }
    }
}
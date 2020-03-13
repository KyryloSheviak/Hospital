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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReceptionViewModel reception)
        {
            return View();
        }

        public IActionResult MyAppointments()
        {
            List<ReceptionDTO> receptions = new List<ReceptionDTO>()
            {
                new ReceptionDTO
                {
                    Doctor = "Doctor 1",
                    ReceptionDateTime = DateTime.Now.ToString("MM/dd/yy"),
                    ReceptionDuration = DateTime.Now.ToString("H:mm"),
                    ReceptionStatus = ReceptionStatus.CANCELED,
                    RoomNumber = 229
                },
                new ReceptionDTO
                {
                    Doctor = "Doctor 2",
                    ReceptionDateTime = DateTime.Now.ToString("MM/dd/yy"),
                    ReceptionDuration = DateTime.Now.ToString("H:mm"),
                    ReceptionStatus = ReceptionStatus.VISITED,
                    RoomNumber = 030
                },
                new ReceptionDTO
                {
                    Doctor = "Doctor 3",
                    ReceptionDateTime = DateTime.Now.ToString("MM/dd/yy"),
                    ReceptionDuration = DateTime.Now.ToString("H:mm"),
                    ReceptionStatus = ReceptionStatus.NOT_VISITED,
                    RoomNumber = 111
                }

            };
            return View(receptions);
        }
    }
}
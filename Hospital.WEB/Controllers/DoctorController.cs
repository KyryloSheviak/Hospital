using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hospital.BL.DTO;
using Hospital.BL.Interface;
using Hospital.WEB.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("doctor")]
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public IActionResult Index()
        {
            return View();
        }

        [Route("work-days")]
        public IActionResult AddWorkDays(DoctorAddWorkDays doctorAddWorkDays)
        {
            if (ModelState.IsValid)
            {
                var days = _mapper.Map<IEnumerable<DoctorWorkDaysDTO>>(doctorAddWorkDays);
                _doctorService.AddWordDays(days);

                TempData["message"] = string.Format("Рабочие дни были добавлены!");
                return RedirectToRoute(new
                {
                    controller = "Doctor",
                    action = "Index"
                });
            }

            return View(doctorAddWorkDays); 
        }

        public IActionResult UpdateReception() { return null; }
        public IActionResult GetInfoByUser() { return null; }
        public IActionResult GetReviews() { return null; }
    }
}
using System;
using System.Security.Claims;
using AutoMapper;
using Hospital.BL.Interface;
using Hospital.WEB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("doctor")]
    [Authorize(Roles = "doctor")]
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("work-days")]
        public IActionResult AddWorkDays() => View();

        [Route("work-days")]
        public IActionResult AddWorkDays(DoctorAddWorkDays doctorAddWorkDays)
        {
            if (ModelState.IsValid)
            {
                var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                _doctorService.AddWordDays(doctorAddWorkDays.DateOfWork, userId);

                TempData["message"] = string.Format("Рабочие дни с графиком были добавлены!");

                return RedirectToAction("Index", "Doctor");
            }

            return View();
        }

        [Route("test1")]
        public IActionResult UpdateReception() { return null; }

        [Route("user/{id}")]
        [HttpGet]
        public IActionResult GetUserInfoById(int id) 
        {
            var user = _doctorService.GetUserInfoById(id);
            var userViewModel = _mapper.Map<AboutUserViewModel>(user);

            return View(userViewModel);
        }

        [Route("test3")]
        public IActionResult GetFeedbacks() { return null; }

        public IActionResult GetStatistic() { return NoContent(); }
    }
}
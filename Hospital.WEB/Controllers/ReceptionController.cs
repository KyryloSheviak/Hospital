using AutoMapper;
using Hospital.BL.DTO;
using Hospital.BL.Interface;
using Hospital.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace Hospital.WEB.Controllers
{
    [Route("reception")]
    [Authorize(Roles = "patient")]
    public class ReceptionController : Controller
    {
        private readonly IReceptionService _receptionService;
        private readonly IMapper _mapper;

        public ReceptionController(IMapper mapper, IReceptionService receptionService)
        {
            _mapper = mapper;
            _receptionService = receptionService;
        }

        [HttpGet]
        [Route("getdoctors")]
        public IActionResult GetDoctors()
        {
            var doctors = _receptionService.GetReceptionDoctors();
            return new JsonResult(doctors);
        }

        [HttpGet]
        [Route("getdoctor/workdays/{id}")]
        public IActionResult GetDoctorsWorkDaysById(int id)
        {
            var workDays = _receptionService.GetReceptionDoctorWorkDays(id);
            return new JsonResult(workDays);
        }

        [HttpGet]
        [Route("getdoctor/worktimes/{day}")]
        public IActionResult GetDoctorsWorkTimesByDay(string day)
        {
            var workTimes = _receptionService.GetReceptionDoctorWorkTimes(day);
            return new JsonResult(workTimes);
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create() => View();

        [HttpPost]
        [Route("create")]
        public IActionResult Create(ReceptionViewModel reception)
        {
            if (ModelState.IsValid)
            {
                var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                var receptionDto = _mapper.Map<ReceptionWorkDayDTO>(reception);
                receptionDto.PatientId = userId;

                var result = _receptionService.CreateVisit(receptionDto);
                if (result)
                {
                    TempData["message"] = string.Format("Вы записаны на прием!");
                    return RedirectToAction("Index", "Home");
                }
                else
                    TempData["message"] = string.Format("Упс! Кто-то уже записался в это время!");
            }

            return View();
        }

       public IActionResult GetAllReceptions() { return null; }
       public IActionResult InsertReception() { return null; }
       public IActionResult UpdateReception() { return null; }
       public IActionResult DeleteReception() { return null; }
    }
}
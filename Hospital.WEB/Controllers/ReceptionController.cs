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
        [Authorize(Roles = "patient")]
        public IActionResult GetDoctors()
        {
            var doctors = _receptionService.GetReceptionDoctors();
            return new JsonResult(doctors);
        }

        [HttpGet]
        [Route("getdoctor/workdays/{id}")]
        [Authorize(Roles = "patient")]
        public IActionResult GetDoctorsWorkDaysById(int id)
        {
            var workDays = _receptionService.GetReceptionDoctorWorkDays(id);
            return new JsonResult(workDays);
        }

        [HttpGet]
        [Route("getdoctor/worktimes/{day}")]
        [Authorize(Roles = "patient")]
        public IActionResult GetDoctorsWorkTimesByDay(string day)
        {
            var workTimes = _receptionService.GetReceptionDoctorWorkTimes(day);
            return new JsonResult(workTimes);
        }

        [HttpGet]
        [Route("create")]
        [Authorize(Roles = "patient")]
        public IActionResult InsertReception() => View();

        [HttpPost]
        [Route("create")]
        [Authorize(Roles = "patient")]
        public IActionResult InsertReception(ReceptionViewModel reception)
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

        [HttpGet]
        [Route("active")]
        [Authorize(Roles = "patient")]
        public IActionResult GetActiveReceptionsByUser()
        {
            return View();
        }

        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "manager")]
        public IActionResult GetAllReceptions() { return View(); }
        public IActionResult UpdateReception() { return null; }
        public IActionResult DeleteReception() { return null; }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hospital.WEB.Models;
using Hospital.BL.DTO;
using Hospital.BL.Interface;
using AutoMapper;

namespace Hospital.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IAdminService adminService, IMapper mapper)
        {
            _logger = logger;
            _adminService = adminService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var test = _adminService.GetUsers();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

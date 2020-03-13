using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hospital.BL.Interface;
using AutoMapper;
using Hospital.WEB.Models;

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
            return View(test);
        }

        public IActionResult Contacts()
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

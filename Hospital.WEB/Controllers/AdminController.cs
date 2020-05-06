using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Hospital.BL.Interface;
using Hospital.DAL.Entities;
using Hospital.WEB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("admin")]
    //[Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public AdminController(IAdminService adminService, IMapper mapper, 
            RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)
        {
            _adminService = adminService;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public ActionResult Index() => View();

        [Route("create/doctor")]
        public ActionResult CreateDoctor() => View();

        [HttpPost]
        [Route("create/doctor")]
        public async Task<IActionResult> CreateDoctor(DoctorViewModel doctorViewModel)
        {
            if (ModelState.IsValid) 
            {
                var user = _mapper.Map<ApplicationUser>(doctorViewModel);
                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "doctor");
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            } 
            
            return View("CreateDoctor", doctorViewModel);
        }

        [HttpGet]
        [Route("create/manager")]
        public ActionResult CreateManager() => View();

        [HttpPost]
        [Route("create/manager")]
        public async Task<IActionResult> CreateManager(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var manager = _mapper.Map<ApplicationUser>(userViewModel);
                var result = await _userManager.CreateAsync(manager);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(manager, "manager");
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View("CreateManager", userViewModel);
        }

        [HttpGet]
        [Route("get/{role}")]
        public async Task<IActionResult> GetUsersByRole(string role)
        {
            var users = await GetUsersViewModel(role);
            ViewData["Role"] = role;

            return View(users);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id, string role)
        {
            var result = await _adminService.DeleteUserById(id);

            if (result.Succeeded)
            {
                TempData["message"] = string.Format("Пользователь был удален!");
                return RedirectToRoute(new
                {
                    controller = "Admin",
                    action = "GetUsersByRole",
                    role = role
                });
            }

            return NotFound();
        }

        private async Task<IEnumerable<UserViewModel>> GetUsersViewModel(string role)
        {
            var usersDto = await _adminService.GetUsersByRole(role);
            var userViewModel = _mapper.Map<IEnumerable<UserViewModel>>(usersDto);

            return userViewModel;
        }
    }
}
using AutoMapper;
using Hospital.BL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;

        public PatientController(IPatientService patientService, IMapper mapper)
        {
            _patientService = patientService;
            _mapper = mapper;
        }

        public IActionResult GetActiveReceptions() { return NoContent(); }
    }
}
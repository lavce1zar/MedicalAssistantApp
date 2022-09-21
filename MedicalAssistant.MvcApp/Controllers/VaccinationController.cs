using AutoMapper;
using MedicalAssiastant.Core.Abstractions;
using MedicalAssistant.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAssistant.MvcApp.Controllers
{
    public class VaccinationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IVaccinationService _vaccinationService;

        public VaccinationController(IMapper mapper, IVaccinationService vaccinationService)
        {
            _mapper = mapper;
            _vaccinationService = vaccinationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var vaccinations = (await _vaccinationService.GetVaccinationsAsync()).Select(dto => _mapper.Map<VaccinationModel>(dto)).ToList();

            return View(vaccinations);
        }

        [HttpGet]
        public async Task<IActionResult> Index2()
        {
            var vaccinationsById = (await _vaccinationService.GetVaccinationsByPatientIdAsync(new Guid("bcdbf5dd-f955-4877-9572-a1fbc52cef4d")))
                .Select(dto => _mapper.Map<VaccinationModel>(dto)).ToList();

            return View(vaccinationsById);
        }
    }
}

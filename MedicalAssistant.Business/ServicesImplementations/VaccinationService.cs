using AutoMapper;
using MedicalAssiastant.Core.Abstractions;
using MedicalAssiastant.Core.DataTransferObjects;
using MedicalAssistant.DataBase;
using Microsoft.EntityFrameworkCore;

namespace MedicalAssistant.MvcApp.Services
{
    public class VaccinationService : IVaccinationService
    {
        private readonly MedicalAssistantContext _databaseContext;
        private readonly IMapper _mapper;

        public VaccinationService(MedicalAssistantContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public async Task<List<VaccinationDto>> GetVaccinationsAsync() => await _databaseContext.Vaccinations.Select(vac => _mapper.Map<VaccinationDto>(vac)).ToListAsync();

        public async Task<List<VaccinationDto>> GetVaccinationsByPatientIdAsync(Guid patientId)
        {
            return await _databaseContext.Vaccinations
                .Select(vac => _mapper.Map<VaccinationDto>(vac))
                .Where(vac => vac.PatientId == patientId)
                .ToListAsync();
        }
    }
}
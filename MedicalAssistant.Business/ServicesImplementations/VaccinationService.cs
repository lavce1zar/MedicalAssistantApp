using AutoMapper;
using MedicalAssiastant.Core.Abstractions;
using MedicalAssiastant.Core.DataTransferObjects;
using MedicalAssistant.DataBase;

namespace MedicalAssistant.MvcApp.Services
{
    public class VaccinationService : IVaccinationService
    {
        private readonly MedicalAssistantContext _databaseContext;
        private readonly IMapper _mapper;

        public VaccinationService(MedicalAssistantContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Task<List<VaccinationDto>> GetVaccinationsByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}

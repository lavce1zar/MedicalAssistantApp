using MedicalAssiastant.Core.Abstractions;
using MedicalAssiastant.Core.DataTransferObjects;

namespace MedicalAssistant.MvcApp.Services
{
    public class VaccinationService : IVaccinationService
    {
        public Task<List<VaccinationDto>> GetVaccinationsByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}

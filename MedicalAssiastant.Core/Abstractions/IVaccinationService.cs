using MedicalAssiastant.Core.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssiastant.Core.Abstractions
{
    public interface IVaccinationService
    {
        Task<List<VaccinationDto>> GetVaccinationsByPageNumberAndPageSizeAsync (int pageNumber, int pageSize);
    }
}

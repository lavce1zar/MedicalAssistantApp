using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssiastant.Core.DataTransferObjects
{
    public class VaccinationDto
    {
        public Guid Id { get; set; }
        public DateTime DateOfVaccination { get; set; }
        public DateTime DateOfNextVaccination { get; set; }
        public Guid VaccineId { get; set; }
        public Guid PatientId { get; set; }
    }
}

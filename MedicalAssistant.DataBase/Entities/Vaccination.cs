using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistant.DataBase.Entities
{
    public class Vaccination
    {
        public Guid Id { get; set; }
        public DateTime DateOfVaccination { get; set; }
        public DateTime DateOfNextVaccination { get; set; }

        public Guid VaccineId { get; set; }
        public Vaccine Vaccine { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}

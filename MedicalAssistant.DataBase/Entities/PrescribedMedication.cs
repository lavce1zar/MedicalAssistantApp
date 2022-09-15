using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistant.DataBase.Entities
{
    public class PrescribedMedication
    {
        public Guid Id { get; set; }
        public string Dosage { get; set; }

        public Guid MedicineId { get; set; }
        public Medicine Medicine { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public Guid DoctorVisitId { get; set; }
        public DoctorVisit DoctorVisit { get; set; }
    }
}

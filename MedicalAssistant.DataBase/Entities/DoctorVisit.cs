using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistant.DataBase.Entities
{
    public class DoctorVisit
    {
        public Guid Id { get; set; }
        public DateTime DateOfVisit { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}

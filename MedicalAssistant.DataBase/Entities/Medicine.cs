using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistant.DataBase.Entities
{
    public class Medicine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public Guid FormOfMedicineId { get; set; }
        public FormOfMedicine FormOfMedicine { get; set; }
    }
}

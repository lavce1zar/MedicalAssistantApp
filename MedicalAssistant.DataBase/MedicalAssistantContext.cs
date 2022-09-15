using MedicalAssistant.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistant.DataBase
{
    public class MedicalAssistantContext : DbContext
    {
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorVisit> DoctorVisits { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<FormOfMedicine> FormsOfMedicine { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PrescribedMedication> PrescribedMedications { get; set; }

        public MedicalAssistantContext(DbContextOptions<MedicalAssistantContext> options)
        : base(options)
        {
        }
    }
}

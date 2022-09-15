namespace MedicalAssistant.MvcApp.Models
{
    public class VaccinationModel
    {
        public Guid Id { get; set; }
        public DateTime DateOfVaccination { get; set; }
        public DateTime DateOfNextVaccination { get; set; }
        public Guid VaccineId { get; set; }
        public Guid PatientId { get; set; }
    }
}

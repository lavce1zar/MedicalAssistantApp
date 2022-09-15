namespace MedicalAssistant.DataBase.Entities
{
    public class Vaccine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameOfProtectedDisease { get; set; }
        public int Cost { get; set; }
    }
}
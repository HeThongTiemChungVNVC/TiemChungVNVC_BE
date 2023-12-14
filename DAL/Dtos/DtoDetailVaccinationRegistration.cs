namespace DAL.Dtos
{
    public class DtoDetailVaccinationRegistration : BaseEntity
    {
        public DateTime DateVaccination { get; set; }
        public string Description { get; set; }
        public string IdVaccinationRegistration { get; set; }
        public bool Status { get; set; }
        public DtoVaccinationRegistration VaccinationRegistration { get; set; }
    }
}
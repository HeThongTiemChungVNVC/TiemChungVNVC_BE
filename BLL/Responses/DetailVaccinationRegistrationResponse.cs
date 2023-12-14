using DAL.Dtos;

namespace BLL.Responses
{
    public class DetailVaccinationRegistrationResponse : BaseEntity
    {
        public DateTime DateVaccination { get; set; }
        public string Description { get; set; }
        public string IdVaccinationRegistration { get; set; }
        public bool Status { get; set; }
        public VaccinationRegistrationResponse VaccinationRegistration { get; set; }
    }
}
namespace DAL.Dtos
{
    public class DtoEmployee : BaseEntity
    {
        public string CodeEmployee { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdCategoryPosition { get; set; }
        public DtoCategoryPosition CategoryPosition { get; set; }
        public string IdVaccinationCenter { get; set; }
        public DtoVaccinationCenter VaccinationCenter { get; set; }
        public List<DtoVaccinationRegistration> VaccinationRegistrations { get; set; }
    }
}
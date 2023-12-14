namespace DAL.Dtos
{
    public class DtoCustomer : BaseEntity
    {
        public string CodeCustomer { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<DtoVaccinationRegistration> VaccinationRegistrations { get; set; }
        public ICollection<DtoMedicalRecord> MedicalRecords { get; set; }

        public DtoCustomer()
        {
            VaccinationRegistrations = new HashSet<DtoVaccinationRegistration>();
            MedicalRecords = new HashSet<DtoMedicalRecord>();
        }
    }
}
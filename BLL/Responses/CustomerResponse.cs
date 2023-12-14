using DAL.Dtos;

namespace BLL.Responses
{
    public class CustomerResponse : BaseEntity
    {
        public string CodeCustomer { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public List<MedicalRecordResponse> MedicalRecords { get; set; }
        public List<VaccinationRegistrationResponse> VaccinationRegistrations { get; set; }

        public CustomerResponse()
        {
            MedicalRecords = new List<MedicalRecordResponse>();
            VaccinationRegistrations = new List<VaccinationRegistrationResponse>();
        }
    }
}
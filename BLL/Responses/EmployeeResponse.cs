using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class EmployeeResponse : BaseEntity
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string CodeEmployee { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdCategoryPosition { get; set; }
        public CategoryPositionResponse CategoryPosition { get; set; }
        public string IdVaccinationCenter { get; set; }
        public VaccinationCenterResponse VaccinationCenter { get; set; }
        public List<VaccinationRegistrationResponse> VaccinationRegistrations { get; set; }
    }
}
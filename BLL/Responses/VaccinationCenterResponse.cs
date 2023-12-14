using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class VaccinationCenterResponse : BaseEntity
    {
        public string? CenterName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public List<VaccinationRegistrationResponse> VaccinationRegistrations { get; set; }
        public List<EmployeeResponse> Employees { get; set; }

        public VaccinationCenterResponse()
        {
            Employees = new List<EmployeeResponse>();
            VaccinationRegistrations = new List<VaccinationRegistrationResponse>();
        }
    }
}
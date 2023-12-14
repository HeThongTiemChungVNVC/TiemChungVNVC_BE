using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class DtoVaccinationCenter : BaseEntity
    {
        public string? CenterName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public ICollection<DtoVaccinationRegistration> VaccinationRegistrations { get; set; }
        public ICollection<DtoEmployee> Employees { get; set; }

        public DtoVaccinationCenter()
        {
            Employees = new HashSet<DtoEmployee>();
            VaccinationRegistrations = new HashSet<DtoVaccinationRegistration>();
        }
    }
}
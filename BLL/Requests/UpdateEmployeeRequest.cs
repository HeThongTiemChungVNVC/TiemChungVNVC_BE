using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
    public class UpdateEmployeeRequest
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string IdCategoryPosition { get; set; }
        public string IdVaccinationCenter { get; set; }
    }
}
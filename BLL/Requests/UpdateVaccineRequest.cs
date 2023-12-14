using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
    public class UpdateVaccineRequest
    {
        public string Id { get; set; }
        public string? Prevention { get; set; } // phòng ngừa bệnh gì
        public string? NameVaccine { get; set; }
        public string InjectionSite { get; set; } // vị trí tiêm
        public string? Image { get; set; }
        public string Condition { get; set; } // điều kiện tiêm
        public string CategoryVaccineId { get; set; }
    }
}
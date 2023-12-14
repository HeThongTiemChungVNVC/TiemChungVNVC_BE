using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class VaccineResponse : BaseEntity
    {
        public string? Prevention { get; set; }
        public string? NameVaccine { get; set; }
        public string InjectionSite { get; set; }
        public string? Image { get; set; }
        public string Condition { get; set; }
        public InjectionChartResponse InjectionChart { get; set; }

        //
        public List<VaccineBatchResponse> VaccineBatches { get; set; }

        public string CategoryVaccineId { get; set; }
        public CategoryVaccineResponse CategoryVaccine { get; set; }

        public VaccineResponse()
        {
            VaccineBatches = new List<VaccineBatchResponse>();
        }
    }
}
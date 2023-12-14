using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class CategoryVaccineResponse : BaseEntity
    {
        public string Title { get; set; }
        public List<VaccineResponse> Vaccines { get; set; }

        public CategoryVaccineResponse()
        {
            Vaccines = new List<VaccineResponse>();
        }
    }
}
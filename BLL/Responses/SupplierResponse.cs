using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class SupplierResponse : BaseEntity
    {
        public string NameSupplier { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<VaccineBatchResponse> VaccineBatches { get; set; }

        public SupplierResponse()
        {
            VaccineBatches = new List<VaccineBatchResponse>();
        }
    }
}
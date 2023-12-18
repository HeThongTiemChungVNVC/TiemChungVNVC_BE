using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class MedicalRecordResponse : BaseEntity
    {
        public string CodeMedicalRecord { get; set; }
        public string IdCustomer { get; set; }
        public CustomerResponse Customer { get; set; }
        public List<DetailMedicalRecordResponse> DetailMedicalRecords { get; set; }

        public MedicalRecordResponse()
        {
            DetailMedicalRecords = new List<DetailMedicalRecordResponse>();
        }
    }
}
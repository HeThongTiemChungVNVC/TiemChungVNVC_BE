using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class DtoMedicalRecord : BaseEntity
    {
        public string CodeMedicalRecord { get; set; }
        public string IdCustomer { get; set; }
        public DtoCustomer Customer { get; set; }
        public ICollection<DtoDetailMedicalRecord> DetailMedicalRecords { get; set; }

        public DtoMedicalRecord()
        {
            DetailMedicalRecords = new HashSet<DtoDetailMedicalRecord>();
        }
    }
}
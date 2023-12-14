using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class DetailMedicalRecordResponse : BaseEntity
    {
        public int BodyTemperature { get; set; }
        public string BackgroundIllness { get; set; } // benh nen
        public string IdMedicalRecord { get; set; }
        public MedicalRecordResponse MedicalRecord { get; set; }
    }
}
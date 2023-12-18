using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
    public class CreateDetailMedicalRequest
    {
        public int BodyTemperature { get; set; }
        public string BackgroundIllness { get; set; } // benh nen
        public string IdMedicalRecord { get; set; }
    }
}
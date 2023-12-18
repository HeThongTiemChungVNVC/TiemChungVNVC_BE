using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
    public class UpdateDetailMedicalRequest
    {
        public string Id { get; set; }
        public int BodyTemperature { get; set; }
        public string BackgroundIllness { get; set; } // benh nen
    }
}
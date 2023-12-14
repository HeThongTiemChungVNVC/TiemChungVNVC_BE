using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
    public class CreatePriceVaccineRequest
    {
        public float CostPrice { get; set; }
        public float RetailPrice { get; set; }
        public float PreOrderPrice { get; set; }

        public string IdVaccineBacth { get; set; }
    }
}
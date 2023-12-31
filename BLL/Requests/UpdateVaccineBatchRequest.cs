﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
    public class UpdateVaccineBatchRequest
    {
        public string Id { get; set; }
        public string CodeBatch { get; set; }
        public string Country { get; set; } // use address of supplier
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int QuantityOfVaccine { get; set; }
        public string VaccineId { get; set; }
        public string SupplierId { get; set; }
    }
}
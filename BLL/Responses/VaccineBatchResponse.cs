using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
	public class VaccineBatchResponse : BaseEntity
	{
		public string CodeBatch { get; set; }
		public string Country { get; set; } // use address of supplier
		public DateTime ManufacturingDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public int QuantityOfVaccine { get; set; }
		public PriceVaccineResponse PriceVaccine { get; set; }
		public List<VaccinationRegistrationResponse> VaccinationRegistrations { get; set; }

		//
		public string VaccineId { get; set; }

		public VaccineResponse Vaccine { get; set; }

		//
		public string SupplierId { get; set; }

		public SupplierResponse Supplier { get; set; }
	}
}
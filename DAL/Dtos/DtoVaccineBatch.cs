using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
	public class DtoVaccineBatch : BaseEntity
	{
		public string CodeBatch { get; set; }
		public string Country { get; set; } // use address of supplier
		public DateTime ManufacturingDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public int QuantityOfVaccine { get; set; }
		public string VaccineId { get; set; }
		public string SupplierId { get; set; }
		public DtoPriceVaccine PriceVaccine { get; set; }
		public List<DtoVaccinationRegistration> VaccinationRegistrations { get; set; }
		//

		public DtoVaccine Vaccine { get; set; }

		//

		public DtoSupplier Supplier { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
	public class DtoVaccinationRegistration : BaseEntity
	{
		public string NameCustomer { get; set; }
		public DateTime VaccinationDate { get; set; }
		public string IdVaccineBatch { get; set; }
		public DtoVaccineBatch VaccineBatch { get; set; }
		public string IdVaccinationCenter { get; set; }
		public DtoVaccinationCenter VaccinationCenter { get; set; }
		public int NumberOfDosesRemaining { get; set; }
		public int Status { get; set; }
		public float TotalPrice { get; set; }
		public string Note { get; set; }
		public ICollection<DtoDetailVaccinationRegistration> DetailsVacccinationRegistrations { get; set; }
		public string IdCustomer { get; set; }
		public DtoCustomer Customer { get; set; }
		public string IdEmployee { get; set; }
		public DtoEmployee Employee { get; set; }

		public DtoVaccinationRegistration()
		{
			DetailsVacccinationRegistrations = new HashSet<DtoDetailVaccinationRegistration>();
		}
	}
}
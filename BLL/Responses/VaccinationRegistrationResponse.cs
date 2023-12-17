using DAL.Dtos;
using DAL.FluentAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
	public class VaccinationRegistrationResponse : BaseEntity
	{
		public string NameCustomer { get; set; }
		public DateTime VaccinationDate { get; set; }
		public string IdVaccineBatch { get; set; }
		public VaccineBatchResponse VaccineBatch { get; set; }
		public string IdVaccinationCenter { get; set; }
		public VaccinationCenterResponse VaccinationCenter { get; set; }
		public int NumberOfDosesRemaining { get; set; }
		public int Status { get; set; }
		public float TotalPrice { get; set; }
		public string Note { get; set; }
		public List<DetailVaccinationRegistrationResponse> DetailsVacccinationRegistrations { get; set; }
		public string IdCustomer { get; set; }
		public CustomerResponse Customer { get; set; }
		public string IdEmployee { get; set; }
		public EmployeeResponse Employee { get; set; }

		public VaccinationRegistrationResponse()
		{
			DetailsVacccinationRegistrations = new List<DetailVaccinationRegistrationResponse>();
		}
	}
}
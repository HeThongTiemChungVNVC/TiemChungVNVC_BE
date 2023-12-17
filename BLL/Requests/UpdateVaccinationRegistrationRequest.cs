using BLL.Responses;
using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
	public class UpdateVaccinationRegistrationRequest
	{
		public string Id { get; set; }
		public string? NameCustomer { get; set; }
		public string VaccinationDate { get; set; }
		public string IdVaccineBatch { get; set; }
		public string IdVaccinationCenter { get; set; }
		public int? NumberOfDosesRemaining { get; set; }
		public int? Status { get; set; }
		public string? Note { get; set; }

		public string? IdEmployee { get; set; }
	}
}
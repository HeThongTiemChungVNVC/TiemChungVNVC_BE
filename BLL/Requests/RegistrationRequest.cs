using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
	public class RegistrationRequest
	{
		public string FullName { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public string Dob { get; set; }

		public string Address { get; set; }

		public bool Gender { get; set; }

		public string IdVaccine { get; set; }

		public string IdVaccinationCenter { get; set; }

		public string VaccinationDate { get; set; }

		public string? IdEmployee { get; set; }
	}
}
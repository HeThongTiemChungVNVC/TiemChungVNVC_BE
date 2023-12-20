namespace DAL.Dtos
{
	public class DtoDetailVaccinationRegistration : BaseEntity
	{
		public DateTime DateVaccination { get; set; }
		public string IdVaccinationRegistration { get; set; }
		public string Description { get; set; }
		public int Status { get; set; }
		public DtoVaccinationRegistration VaccinationRegistration { get; set; }
	}
}
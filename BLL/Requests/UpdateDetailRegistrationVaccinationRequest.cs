namespace BLL.Requests
{
	public class UpdateDetailRegistrationVaccinationRequest
	{
		public string Id { get; set; }
		public string? Description { get; set; }
		public int? Status { get; set; }
	}
}
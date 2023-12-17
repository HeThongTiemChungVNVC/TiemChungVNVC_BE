namespace DAL.Dtos
{
	public class DtoInformation : BaseEntity
	{
		public string? FullName { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string? Gender { get; set; }
		public string? Role { get; set; }
		public string? Address { get; set; }
		public DateTime Dob { get; set; }
	}
}
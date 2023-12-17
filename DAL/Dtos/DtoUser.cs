namespace DAL.Dtos
{
	public class DtoUser : BaseEntity
	{
		public string Username { get; set; }
		public string PasswordHash { get; set; }
		public string Role { get; set; }
		public DtoEmployee Employee { get; set; }
		public ICollection<DtoRefeshToken> RefeshTokens { get; set; }
		public ICollection<DtoPasswordRecoveryToken> PasswordRecoveryTokens { get; set; }

		public DtoUser()
		{
			RefeshTokens = new HashSet<DtoRefeshToken>();
			PasswordRecoveryTokens = new HashSet<DtoPasswordRecoveryToken>();
		}
	}
}
namespace DAL.Dtos
{
    public class DtoPasswordRecoveryToken : BaseEntity
    {
        public string PinCode { get; set; }
        public DateTime Expires { get; set; } = DateTime.Now;
        public string UserId { get; set; }
        public DtoUser User { get; set; }
    }
}
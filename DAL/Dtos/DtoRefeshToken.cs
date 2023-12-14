namespace DAL.Dtos
{
    public class DtoRefeshToken : BaseEntity
    {
        public string RefeshToken { get; set; }
        public DateTime Expires { get; set; }
        public string UserId { get; set; }
        public DtoUser User { get; set; }
    }
}
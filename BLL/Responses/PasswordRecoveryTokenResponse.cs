namespace BLL.Responses
{
    public class PasswordRecoveryTokenResponse
    {
        public string PinCode { get; set; }
        public DateTime Expires { get; set; } = DateTime.Now;
        public string UserId { get; set; }
    }
}
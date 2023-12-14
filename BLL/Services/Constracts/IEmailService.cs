namespace BLL.Services.Constracts
{
    public interface IEmailService
    {
        Task<bool> SendEmail(string to, string body, string subject);
    }
}
using BLL.Services.Constracts;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;

namespace BLL.Services.Implementations
{
	public class EmailService : IEmailService
	{
		private readonly ILogger<EmailService> _logger;
		private readonly IConfiguration _configuration;

		public EmailService(ILogger<EmailService> logger, IConfiguration configuration)
		{
			_logger = logger;
			_configuration = configuration;
		}

		public async Task<bool> SendEmail(string to, string body, string subject)
		{
			using var smtp = new SmtpClient();
			try
			{
				string email = _configuration["Google:Email"] ?? throw new Exception("Email null");
				string appSecret = _configuration["Google:AppSecret"] ?? throw new Exception("App secret null");
				var emailSend = new MimeMessage();
				emailSend.From.Add(new MailboxAddress("Tiêm chủng VNVC", email));
				emailSend.To.Add(MailboxAddress.Parse(to));
				emailSend.Subject = subject;
				emailSend.Body = new TextPart(TextFormat.Html) { Text = body };
				smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
				smtp.Authenticate(email, appSecret);
				smtp.Send(emailSend);
				return true;
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return false;
			}
			finally
			{
				smtp.Disconnect(true);
				smtp.Dispose();
			}
		}
	}
}
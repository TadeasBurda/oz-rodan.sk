using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System.Threading.Tasks;

namespace Rodan.Business
{
    public class EmailSender : IEmailSender
    {
		private readonly string name;
		private readonly string adrress;
		private readonly string smtp;
		private readonly int port;
		private readonly bool useSsl;
		private readonly string password;

		public EmailSender(IConfiguration configuration)
		{
			name = configuration["Email:Name"];
			adrress = configuration["Email:Adrress"];
			smtp = configuration["Email:Smtp"];
			port = int.Parse(configuration["Email:Port"]);
			useSsl = bool.Parse(configuration["Email:UseSSL"]);
			password = configuration["Email:Password"];
		}

		public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
			await Task.Run(() =>
			{
				var message = new MimeMessage();
				message.From.Add(new MailboxAddress(name, adrress));
				message.To.Add(new MailboxAddress(email, email));
				message.Subject = subject;
				message.Body = (new BodyBuilder() { HtmlBody = htmlMessage }).ToMessageBody();

				using var client = new SmtpClient();
				client.Connect(smtp, port, useSsl);
				client.Authenticate(adrress, password);
				client.Send(message);
				client.Disconnect(true);
			});
        }
    }
}

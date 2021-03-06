﻿using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System.Threading.Tasks;

namespace Rodan.Business
{
    public class EmailSender : IEmailSender
    {
		private const string name = "OZ Rodan";
		private const string adrress = "postmaster@oz-rodan.sk";
		private const string smtp = "smtp.forpsi.com";
		private const int port = 587;
		private const bool useSsl = false;
		private readonly string password;

		public EmailSender(IConfiguration configuration)
		{
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

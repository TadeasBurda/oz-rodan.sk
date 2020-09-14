using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Rodan.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Rodan.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IEmailSender emailSender;
        private readonly IConfiguration configuration;
        private readonly IFileManager fileManager;

        public AccountService(UserManager<IdentityUser> userManager, IEmailSender emailSender, IConfiguration configuration, IFileManager fileManager)
        {
            this.userManager = userManager;
            this.emailSender = emailSender;
            this.configuration = configuration;
            this.fileManager = fileManager;
        }

        private string GetHtmlMessage(string email, string callbackUrl)
        {
            var keyWords = new Dictionary<string, string>
            {
                { "@date", DateTime.Now.ToString("HH:mm dd.MM.yyyy") },
                { "@email", email},
                { "@link", $"{HtmlEncoder.Default.Encode(callbackUrl)}" }
            };

            string s = fileManager.GetHtmlTemplate("confirm-email.html");
            foreach (string key in keyWords.Keys)
                s = s.Replace(key, keyWords[key]);

            return s;
        }

        private async Task SendConfirmEmailAsync(IdentityUser user)
        {
            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);

            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            string callbackUrl = string.Format("{0}/confirm-email/{1}/{2}", configuration["Web:Url"], user.Id, code);

            await emailSender.SendEmailAsync(user.Email, "Potvrdte svoj email", GetHtmlMessage(user.Email, callbackUrl));
        }

        public async Task RegisterAsync(string email)
        {
            IdentityUser user = await userManager.FindByEmailAsync(email);

            if(user != null)
            {
                if (!user.EmailConfirmed)
                    await SendConfirmEmailAsync(user);
                else
                    throw new Exception($"{email}, už odoberá novinky na tomto webe");
            }
            else
            {
                user = new IdentityUser
                {
                    UserName = email,
                    Email = email
                };
                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                    await SendConfirmEmailAsync(user);
            }
        }
    }
}

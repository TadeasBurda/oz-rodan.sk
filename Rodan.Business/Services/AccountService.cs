using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Rodan.Business.Interfaces;
using System;
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

        public AccountService(UserManager<IdentityUser> userManager, IEmailSender emailSender, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.emailSender = emailSender;
            this.configuration = configuration;
        }

        private async Task SendConfirmEmailAsync(IdentityUser user)
        {
            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);

            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            //string callbackUrl = string.Format("{0}/Identity/Account/ConfirmEmail?userid={1}&code={2}", configuration["Web:Url"], user.Id, code);
            string callbackUrl = string.Format("{0}/confirm-email/{1}/{2}", configuration["Web:Url"], user.Id, code);

            await emailSender.SendEmailAsync(user.Email, "Potvrdte svoj email",
                $"Prosím, potvrdte svoj odber <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>kliknutím sem</a>.");
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

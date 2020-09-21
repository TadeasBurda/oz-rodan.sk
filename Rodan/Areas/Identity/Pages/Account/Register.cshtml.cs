using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Rodan.Business.Interfaces;
using Rodan.Business.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Rodan.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IFileManager fileManager;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IFileManager fileManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            this.fileManager = fileManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "{0} musí mať najmenej {2} a maximálne {1} znakov.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Heslo")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Potvrďte heslo")]
            [Compare("Password", ErrorMessage = "Heslo a heslo na potvrdenie sa nezhodujú.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    await _emailSender.SendEmailAsync(Input.Email, "Potvrdte svoj email", GetHtmlMessage(Input.Email, user.Id, code, returnUrl));

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private string GetHtmlMessage(string email, string userId, string code, string returnUrl)
        {
            var keyWords = new Dictionary<string, string>
            {
                { "@date", DateTime.Now.ToString("HH:mm dd.MM.yyyy") },
                { "@email", email },
                { "@link", HtmlEncoder.Default.Encode(Url.Page("/Account/ConfirmEmail", pageHandler: null, values: new { area = "Identity", userId, code, returnUrl }, protocol: Request.Scheme)) }
            };

            string s = fileManager.GetHtmlTemplate("confirm-email.html");
            foreach (string key in keyWords.Keys)
                s = s.Replace(key, keyWords[key]);

            return s;
        }
    }
}

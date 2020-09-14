using System.ComponentModel.DataAnnotations;

namespace Rodan.Data.ViewModels
{
    public class SubscribeViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}

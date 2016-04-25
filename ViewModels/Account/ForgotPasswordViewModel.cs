using System.ComponentModel.DataAnnotations;

namespace tiqe_web.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

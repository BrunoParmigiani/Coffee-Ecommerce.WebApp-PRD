using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Administrator.ChangePassword
{
    public sealed class ChangeCredentials
    {
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira a senha atual")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Insira a nova senha")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Insira a nova senha")]
        public string ConfirmNewPassword { get; set; }
    }
}

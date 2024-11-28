using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Authentication
{
    public sealed class Credentials
    {
        [Required(ErrorMessage = "Insira o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira a senha")]
        public string Password { get; set; }
    }
}

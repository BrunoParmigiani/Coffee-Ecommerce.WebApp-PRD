using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Administrator.Create
{
    public sealed class CreateRequest
    {
        [Required(ErrorMessage = "Insira o nome do administrador")]
        [Length(3, 100, ErrorMessage = "Um nome deve ter entre 3 a 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Insira um e-mail")]
        [EmailAddress(ErrorMessage = "Formato inválido")]
        [RegularExpression(@"^[^@\s]+@expcafe\.[\w]+$", ErrorMessage = "E-mail de domínio inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira um CPF")]
        [Length(11, 11, ErrorMessage = "CPF não contém 11 caracteres")]
        [RegularExpression(@"(\d+)", ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Insira uma senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Insira um número de telefone")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Escolha um tipo de conta")]
        public string Role { get; set; }

        public Guid? EstablishmentId { get; set; }
    }
}

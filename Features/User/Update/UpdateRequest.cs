using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.User.Update
{
    public sealed class UpdateRequest
    {
        [Required(ErrorMessage = "Insira seu nome")]
        [Length(3, 100, ErrorMessage = "Um nome deve ter entre 3 a 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Insira seu e-mail")]
        [EmailAddress(ErrorMessage = "Formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira seu CPF")]
        [Length(11, 11, ErrorMessage = "CPF não contém 11 caracteres")]
        [RegularExpression(@"(\d+)", ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Insira seu número de telefone")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Insira seu CEP")]
        [Length(9, 9, ErrorMessage = "CEP inválido")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Insira o complemento do seu endereço")]
        public string Complement { get; set; }
    }
}

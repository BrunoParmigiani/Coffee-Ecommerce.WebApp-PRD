using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Establishment.Create
{
    public sealed class CreateRequest
    {
        [Required(ErrorMessage = "Insira um nome")]
        [Length(3, 100, ErrorMessage = "Um nome deve ter entre 3 a 100 caracteres")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Insira um e-mail")]
        [EmailAddress(ErrorMessage = "Formato inválido")]
        [RegularExpression(@"^[^@\s]+@expcafe\.[\w]+$", ErrorMessage = "E-mail de domínio inválido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Insira o CEP")]
        [Length(9, 9, ErrorMessage = "CEP inválido")]
        public string PostalCode { get; set; }
        
        [Required(ErrorMessage = "Insira o CNPJ")]
        [Length(14, 14, ErrorMessage = "CNPJ não contém 14 caracteres")]
        [RegularExpression(@"(\d+)", ErrorMessage = "CNPJ inválido")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Insira o complemento do seu endereço")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "Escolha um administrador")]
        public Guid AdministratorId { get; set; }
        
        [Required(ErrorMessage = "Insira um número de telefone")]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "Insira uma senha")]
        public string Password { get; set; }
    }
}

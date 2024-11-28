using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Footer.Create
{
    public sealed class CreateRequest
    {
        [Required(ErrorMessage = "Insira um nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Insira o link")]
        public string Link { get; set; }
    }
}

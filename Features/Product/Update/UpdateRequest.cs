using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Product.Update
{
    public sealed class UpdateRequest
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Insira um nome")]
        [Length(0, 100, ErrorMessage = "Nome não pode exceder 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Insira um preço")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Insira uma descrição")]
        [Length(0, 255, ErrorMessage = "Descrição não pode exceder 255 caracteres")]
        public string Description { get; set; }

        public Guid EstablishmentId { get; set; }
    }
}
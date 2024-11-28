using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Report.Create
{
    public sealed class CreateRequest
    {
        public Guid EstablishmentId { get; set; }
        public Guid OrderId { get; set; }

        [Required(ErrorMessage = "Selecione um problema")]
        public int Problem { get; set; } = 0;

        [Required(ErrorMessage = "Por favor, nos conte o que aconteceu")]
        [MaxLength(500, ErrorMessage = "A descrição não pode ter mais de 500 caracteres")]
        public string Description { get; set; }
    }
}

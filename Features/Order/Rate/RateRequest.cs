using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Order.Rate
{
    public sealed class RateRequest
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Avalie o tempo de entrega")]
        [Range(1, 5, ErrorMessage = "O valor deve ser entre 1 e 5")]
        public int TimeRating { get; set; }

        [Required(ErrorMessage = "Avalie a qualidade do pedido")]
        [Range(1, 5, ErrorMessage = "O valor deve ser entre 1 e 5")]
        public int QualityRating { get; set; }

        public string? UserComments { get; set; }
    }
}

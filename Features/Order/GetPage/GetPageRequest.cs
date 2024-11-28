using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Order.GetPage
{
    public sealed class GetPageRequest
    {
        [Range(1, long.MaxValue)]
        public int Page { get; set; } = 1;

        [Range(10, 20)]
        public int Items { get; set; } = 10;
        public string? OrderBy { get; set; } = "date_descending";
        public Guid? EstablishmentId { get; set; } = default;
        public Guid? CustomerId { get; set; } = default;
        public DateTime? Date { get; set; } = default;
        public float TotalValue { get; set; } = -1;
    }
}

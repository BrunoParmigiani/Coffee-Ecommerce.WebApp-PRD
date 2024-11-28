namespace Coffee_Ecommerce.WebApp.Features.Report.GetPage
{
    public sealed class PageParameters
    {
        public int Page { get; set; } = 1;
        public int Items { get; set; } = 10;
        public string? OrderBy { get; set; } = "date_descending";
        public Guid? EstablishmentId { get; set; } = default;
        public Guid? CustomerId { get; set; } = default;
        public DateTime? Date { get; set; } = default;
        public int Status { get; set; } = -1;
    }
}

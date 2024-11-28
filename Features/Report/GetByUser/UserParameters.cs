namespace Coffee_Ecommerce.WebApp.Features.Report.GetByUser
{
    public sealed class UserParameters
    {
        public int Page { get; set; } = 1;
        public int Items { get; set; } = 10;
        public string? OrderBy { get; set; } = default;
        public Guid? EstablishmentId { get; set; } = default;
        public DateTime? Date { get; set; } = default;
        public int Status { get; set; } = -1;
    }
}

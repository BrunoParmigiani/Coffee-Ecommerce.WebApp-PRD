namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public sealed class ReportEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid EstablishmentId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int Problem { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}

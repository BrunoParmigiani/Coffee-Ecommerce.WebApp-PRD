using Coffee_Ecommerce.WebApp.Features.Report.GetMessages;

namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public interface IReportMessageClient
    {
        [Get("/api/ReportMessages")]
        Task<GetMessagesResult> GetMessagesAsync(Guid reportId);
    }
}

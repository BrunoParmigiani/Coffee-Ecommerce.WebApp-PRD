using Coffee_Ecommerce.WebApp.Features.Report.Create;
using Coffee_Ecommerce.WebApp.Features.Report.GetPage;
using Coffee_Ecommerce.WebApp.Features.Report.Update;

namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public interface IReportService
    {
        public Task<ReportEntity?> CreateAsync(CreateRequest request);
        public Task<List<ReportEntity>?> GetAllAsync();
        public Task<ReportEntity?> UpdateAsync(UpdateRequest request);
        public Task<bool> DeleteAsync(Guid id);
        public Task<ReportEntity?> GetByIdAsync(Guid id);
        public Task<List<ReportEntity>?> GetPageAsync(PageParameters parameters);
        public Task<List<ReportEntity>?> GetByUserAsync(PageParameters parameters);
        public Task<List<ReportMessage>> GetMessagesAsync(Guid reportId);
    }
}

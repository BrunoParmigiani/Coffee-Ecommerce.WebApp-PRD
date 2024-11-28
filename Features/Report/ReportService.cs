using Coffee_Ecommerce.WebApp.Features.Report.Create;
using Coffee_Ecommerce.WebApp.Features.Report.Delete;
using Coffee_Ecommerce.WebApp.Features.Report.GetAll;
using Coffee_Ecommerce.WebApp.Features.Report.GetById;
using Coffee_Ecommerce.WebApp.Features.Report.GetByUser;
using Coffee_Ecommerce.WebApp.Features.Report.GetMessages;
using Coffee_Ecommerce.WebApp.Features.Report.GetPage;
using Coffee_Ecommerce.WebApp.Features.Report.Update;

namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public sealed class ReportService : IReportService
    {
        private readonly IReportClient _client;
        private readonly IReportMessageClient _messaging;

        public ReportService(IReportClient client, IReportMessageClient messaging)
        {
            _client = client;
            _messaging = messaging;
        }

        public async Task<ReportEntity?> CreateAsync(CreateRequest request)
        {
            CreateResult result = new CreateResult();

            try
            {
                result = await _client.CreateAsync(request);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            DeleteResult result = new DeleteResult();

            try
            {
                result = await _client.DeleteAsync(id);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<ReportEntity>?> GetAllAsync()
        {
            GetAllResult result = new GetAllResult();

            try
            {
                result = await _client.GetAllAsync();
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<ReportEntity?> GetByIdAsync(Guid id)
        {
            GetByIdResult result = new GetByIdResult();

            try
            {
                result = await _client.GetByIdAsync(id);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<ReportEntity>?> GetByUserAsync(PageParameters parameters)
        {
            GetByUserResult result = new GetByUserResult();

            try
            {
                result = await _client.GetByUserAsync(parameters);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<ReportMessage>> GetMessagesAsync(Guid reportId)
        {
            GetMessagesResult result = new GetMessagesResult();

            try
            {
                result = await _messaging.GetMessagesAsync(reportId);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<ReportEntity>?> GetPageAsync(PageParameters parameters)
        {
            GetPageResult result = new GetPageResult();

            try
            {
                result = await _client.GetPageAsync(parameters);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<ReportEntity?> UpdateAsync(UpdateRequest request)
        {
            UpdateResult result = new UpdateResult();

            try
            {
                result = await _client.UpdateAsync(request);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }
    }
}

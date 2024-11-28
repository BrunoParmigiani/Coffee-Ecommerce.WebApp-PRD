using Coffee_Ecommerce.WebApp.Features.Report.Create;
using Coffee_Ecommerce.WebApp.Features.Report.Delete;
using Coffee_Ecommerce.WebApp.Features.Report.GetAll;
using Coffee_Ecommerce.WebApp.Features.Report.GetById;
using Coffee_Ecommerce.WebApp.Features.Report.GetByUser;
using Coffee_Ecommerce.WebApp.Features.Report.GetPage;
using Coffee_Ecommerce.WebApp.Features.Report.Update;

namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public interface IReportClient
    {
        [Post("/api/Report")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);

        [Get("/api/Report")]
        Task<GetAllResult> GetAllAsync();

        [Put("/api/Report")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);

        [Delete("/api/Report/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);

        [Get("/api/Report/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);

        [Get("/api/Report/page")]
        Task<GetPageResult> GetPageAsync([Query] PageParameters parameters);

        [Get("/api/Report/user")]
        Task<GetByUserResult> GetByUserAsync([Query] PageParameters parameters);

    }
}

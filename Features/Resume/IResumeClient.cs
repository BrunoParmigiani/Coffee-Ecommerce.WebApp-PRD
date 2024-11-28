using Coffee_Ecommerce.WebApp.Features.Resume.GetAll;
using Coffee_Ecommerce.WebApp.Features.Resume.Delete;
using Coffee_Ecommerce.WebApp.Features.Resume.GetById;
using Coffee_Ecommerce.WebApp.Features.Resume.Upload;

namespace Coffee_Ecommerce.WebApp.Features.Resume
{
    public interface IResumeClient
    {
        [Post("/api/Resume")]
        Task<UploadResult> UploadAsync([Body] UploadRequest request);

        [Get("/api/Resume")]
        Task<GetAllResult> GetAllAsync();

        [Get("/api/Resume/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);

        [Delete("/api/Resume/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);
    }
}

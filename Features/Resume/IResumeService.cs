using Microsoft.AspNetCore.Components.Forms;

namespace Coffee_Ecommerce.WebApp.Features.Resume
{
    public interface IResumeService
    {
        public Task<bool> UploadAsync(IBrowserFile file);
        public Task<List<S3Object>> GetAllAsync();
        public Task<S3Object> GetByIdAsync(Guid id);
        public Task<bool> DeleteAsync(Guid id);
    }
}

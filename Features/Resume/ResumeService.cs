using Coffee_Ecommerce.WebApp.Features.Resume.Delete;
using Coffee_Ecommerce.WebApp.Features.Resume.GetAll;
using Coffee_Ecommerce.WebApp.Features.Resume.GetById;
using Coffee_Ecommerce.WebApp.Features.Resume.Upload;
using Microsoft.AspNetCore.Components.Forms;

namespace Coffee_Ecommerce.WebApp.Features.Resume
{
    public sealed class ResumeService : IResumeService
    {
        private readonly IResumeClient _client;
        
        public ResumeService(IResumeClient client)
        {
            _client = client;
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
            catch (HttpRequestException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<S3Object>> GetAllAsync()
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
            catch (HttpRequestException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<S3Object> GetByIdAsync(Guid id)
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
            catch (HttpRequestException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<bool> UploadAsync(IBrowserFile file)
        {
            UploadResult uploadResult = new UploadResult();

            try
            {
                if (file.ContentType != "application/pdf")
                    throw new FileLoadException("Invalid file format");

                var stream = file.OpenReadStream();
                byte[] bytes = await FileConverter.ConvertFileToBytesAsync(stream);

                var request = new UploadRequest { FileBytes = bytes };

                var result = await _client.UploadAsync(request);

                uploadResult = result;
            }
            catch (ApiException)
            {
                throw;
            }
            catch (HttpRequestException)
            {
                throw;
            }

            return uploadResult.Data;
        }
    }
}

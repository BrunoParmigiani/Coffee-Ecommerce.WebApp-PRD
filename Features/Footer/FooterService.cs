using Coffee_Ecommerce.WebApp.Features.Footer.Create;
using Coffee_Ecommerce.WebApp.Features.Footer.Delete;
using Coffee_Ecommerce.WebApp.Features.Footer.GetAll;
using Coffee_Ecommerce.WebApp.Features.Footer.GetById;
using Coffee_Ecommerce.WebApp.Features.Footer.Update;

namespace Coffee_Ecommerce.WebApp.Features.Footer
{
    public sealed class FooterService : IFooterService
    {
        private readonly IFooterClient _client;
        
        public FooterService(IFooterClient client)
        {
            _client = client;
        }

        public async Task<FooterItemEntity?> CreateAsync(CreateRequest request)
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

        public async Task<List<FooterItemEntity>?> GetAllAsync()
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

        public async Task<FooterItemEntity?> GetByIdAsync(Guid id)
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

        public async Task<FooterItemEntity?> UpdateAsync(UpdateRequest request)
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

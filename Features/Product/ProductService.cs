using Coffee_Ecommerce.WebApp.Features.Product.Create;
using Coffee_Ecommerce.WebApp.Features.Product.Delete;
using Coffee_Ecommerce.WebApp.Features.Product.GetAll;
using Coffee_Ecommerce.WebApp.Features.Product.GetByEstablishment;
using Coffee_Ecommerce.WebApp.Features.Product.GetById;
using Coffee_Ecommerce.WebApp.Features.Product.Update;

namespace Coffee_Ecommerce.WebApp.Features.Product
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductClient _client;

        public ProductService(IProductClient client)
        {
            _client = client;
        }

        public async Task<ProductEntity?> CreateAsync(CreateRequest request)
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

        public async Task<List<ProductEntity>?> GetAllAsync()
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

        public async Task<List<ProductEntity>?> GetByEstablishmentAsync(Guid id)
        {
            GetByEstablishmentResult result = new GetByEstablishmentResult();

            try
            {
                result = await _client.GetByEstablishmentAsync(id);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<ProductEntity?> GetByIdAsync(Guid id)
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

        public async Task<ProductEntity?> UpdateAsync(UpdateRequest request)
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
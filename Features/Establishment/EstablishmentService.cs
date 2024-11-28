using Coffee_Ecommerce.WebApp.Features.Establishment.Block;
using Coffee_Ecommerce.WebApp.Features.Establishment.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.Establishment.Create;
using Coffee_Ecommerce.WebApp.Features.Establishment.Delete;
using Coffee_Ecommerce.WebApp.Features.Establishment.GetAll;
using Coffee_Ecommerce.WebApp.Features.Establishment.GetById;
using Coffee_Ecommerce.WebApp.Features.Establishment.Update;

namespace Coffee_Ecommerce.WebApp.Features.Establishment
{
    public sealed class EstablishmentService : IEstablishmentService
    {
        private readonly IEstablishmentClient _client;

        public EstablishmentService(IEstablishmentClient client)
        {
            _client = client;
        }

        public async Task<Tuple<bool, string?>?> BlockAsync(Guid id)
        {
            BlockResult result = new BlockResult();

            try
            {
                result = await _client.BlockAsync(id);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<bool> ChangePasswordAsync(ChangeCredentials credentials)
        {
            ChangePasswordResult result = new ChangePasswordResult();

            try
            {
                result = await _client.ChangePasswordAsync(credentials);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<EstablishmentEntity?> CreateAsync(CreateRequest request)
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

        public async Task<List<EstablishmentEntity>?> GetAllAsync()
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

        public async Task<EstablishmentEntity?> GetByIdAsync(Guid id)
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

        public async Task<EstablishmentEntity?> GetInfoAsync()
        {
            GetByIdResult result = new GetByIdResult();

            try
            {
                result = await _client.GetInfoAsync();
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<EstablishmentEntity?> UpdateAsync(UpdateRequest request)
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

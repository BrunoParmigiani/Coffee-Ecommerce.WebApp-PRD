using Coffee_Ecommerce.WebApp.Features.Administrator.Block;
using Coffee_Ecommerce.WebApp.Features.Administrator.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.Administrator.Create;
using Coffee_Ecommerce.WebApp.Features.Administrator.Delete;
using Coffee_Ecommerce.WebApp.Features.Administrator.GetAll;
using Coffee_Ecommerce.WebApp.Features.Administrator.GetById;
using Coffee_Ecommerce.WebApp.Features.Administrator.Update;

namespace Coffee_Ecommerce.WebApp.Features.Administrator
{
    public sealed class AdministratorService : IAdministratorService
    {
        private readonly IAdministratorClient _client;

        public AdministratorService(IAdministratorClient client)
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

        public async Task<AdministratorEntity?> CreateAsync(CreateRequest request)
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

        public async Task<List<AdministratorEntity>?> GetAllAsync()
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

        public async Task<AdministratorEntity?> GetByIdAsync(Guid id)
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

        public async Task<AdministratorEntity?> GetInfoAsync()
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

        public async Task<AdministratorEntity?> UpdateAsync(UpdateRequest request)
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

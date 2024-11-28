using Coffee_Ecommerce.WebApp.Features.User.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.User.Create;
using Coffee_Ecommerce.WebApp.Features.User.Delete;
using Coffee_Ecommerce.WebApp.Features.User.GetById;
using Coffee_Ecommerce.WebApp.Features.User.Recovery;
using Coffee_Ecommerce.WebApp.Features.User.Update;

namespace Coffee_Ecommerce.WebApp.Features.User
{
    public sealed class UserService : IUserService
    {
        private readonly IUserClient _client;

        public UserService(IUserClient client)
        {
            _client = client;
        }

        public async Task<UserEntity?> CreateAsync(CreateRequest request)
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

        public async Task<UserEntity?> UpdateAsync(UpdateRequest request)
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

        public async Task<bool> DeleteAsync()
        {
            DeleteResult result = new DeleteResult();

            try
            {
                result = await _client.DeleteAsync();
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<UserEntity?> GetByIdAsync(Guid id)
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

        public async Task<UserEntity?> GetInfoAsync()
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

        public async Task<bool> RecoverAccountAsync()
        {
            RecoveryResult result = new RecoveryResult();

            try
            {
                result = await _client.RecoverAccountAsync();
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
    }
}

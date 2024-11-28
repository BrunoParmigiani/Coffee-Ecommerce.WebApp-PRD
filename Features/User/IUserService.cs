using Coffee_Ecommerce.WebApp.Features.User.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.User.Create;
using Coffee_Ecommerce.WebApp.Features.User.Update;

namespace Coffee_Ecommerce.WebApp.Features.User
{
    public interface IUserService
    {
        Task<UserEntity?> CreateAsync(CreateRequest request);
        Task<UserEntity?> UpdateAsync(UpdateRequest request);
        Task<bool> DeleteAsync();
        Task<UserEntity?> GetByIdAsync(Guid id);
        Task<UserEntity?> GetInfoAsync();
        Task<bool> RecoverAccountAsync();
        Task<bool> ChangePasswordAsync(ChangeCredentials credentials);
    }
}

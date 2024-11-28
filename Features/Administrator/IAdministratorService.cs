using Coffee_Ecommerce.WebApp.Features.Administrator.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.Administrator.Create;
using Coffee_Ecommerce.WebApp.Features.Administrator.Update;

namespace Coffee_Ecommerce.WebApp.Features.Administrator
{
    public interface IAdministratorService
    {
        Task<AdministratorEntity?> CreateAsync(CreateRequest request);
        Task<List<AdministratorEntity>?> GetAllAsync();
        Task<AdministratorEntity?> UpdateAsync(UpdateRequest request);
        Task<bool> DeleteAsync(Guid id);
        Task<AdministratorEntity?> GetByIdAsync(Guid id);
        Task<AdministratorEntity?> GetInfoAsync();
        Task<Tuple<bool, string?>?> BlockAsync(Guid id);
        Task<bool> ChangePasswordAsync(ChangeCredentials credentials);
    }
}

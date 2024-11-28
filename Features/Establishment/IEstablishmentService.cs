using Coffee_Ecommerce.WebApp.Features.Establishment.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.Establishment.Create;
using Coffee_Ecommerce.WebApp.Features.Establishment.Update;

namespace Coffee_Ecommerce.WebApp.Features.Establishment
{
    public interface IEstablishmentService
    {
        Task<EstablishmentEntity?> CreateAsync(CreateRequest request);
        Task<List<EstablishmentEntity>?> GetAllAsync();
        Task<EstablishmentEntity?> UpdateAsync(UpdateRequest request);
        Task<bool> DeleteAsync(Guid id);
        Task<EstablishmentEntity?> GetByIdAsync(Guid id);
        Task<EstablishmentEntity?> GetInfoAsync();
        Task<Tuple<bool, string?>?> BlockAsync(Guid id);
        Task<bool> ChangePasswordAsync(ChangeCredentials credentials);
    }
}

using Coffee_Ecommerce.WebApp.Features.Establishment.Block;
using Coffee_Ecommerce.WebApp.Features.Establishment.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.Establishment.Create;
using Coffee_Ecommerce.WebApp.Features.Establishment.Delete;
using Coffee_Ecommerce.WebApp.Features.Establishment.GetAll;
using Coffee_Ecommerce.WebApp.Features.Establishment.GetById;
using Coffee_Ecommerce.WebApp.Features.Establishment.Update;

namespace Coffee_Ecommerce.WebApp.Features.Establishment
{
    public interface IEstablishmentClient
    {
        [Post("/api/Establishment")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);
        
        [Get("/api/Establishment")]
        Task<GetAllResult> GetAllAsync();
        
        [Put("/api/Establishment")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);
        
        [Delete("/api/Establishment/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);
        
        [Get("/api/Establishment/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);
        
        [Get("/api/Establishment/getinfo")]
        Task<GetByIdResult> GetInfoAsync();
        
        [Put("/api/Establishment/block/{id}")]
        Task<BlockResult> BlockAsync(Guid id);
        
        [Post("/api/Establishment/changepassword")]
        Task<ChangePasswordResult> ChangePasswordAsync([Body] ChangeCredentials credentials);
    }
}

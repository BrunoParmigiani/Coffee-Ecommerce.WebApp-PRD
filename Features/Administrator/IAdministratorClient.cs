using Coffee_Ecommerce.WebApp.Features.Administrator.Block;
using Coffee_Ecommerce.WebApp.Features.Administrator.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.Administrator.Create;
using Coffee_Ecommerce.WebApp.Features.Administrator.Delete;
using Coffee_Ecommerce.WebApp.Features.Administrator.GetAll;
using Coffee_Ecommerce.WebApp.Features.Administrator.GetById;
using Coffee_Ecommerce.WebApp.Features.Administrator.Update;

namespace Coffee_Ecommerce.WebApp.Features.Administrator
{
    public interface IAdministratorClient
    {
        [Post("/api/Administrator")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);
        
        [Get("/api/Administrator")]
        Task<GetAllResult> GetAllAsync();
        
        [Put("/api/Administrator")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);
        
        [Delete("/api/Administrator/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);
        
        [Get("/api/Administrator/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);
        
        [Get("/api/Administrator/getinfo")]
        Task<GetByIdResult> GetInfoAsync();
        
        [Put("/api/Administrator/block/{id}")]
        Task<BlockResult> BlockAsync(Guid id);
        
        [Post("/api/Administrator/changepassword")]
        Task<ChangePasswordResult> ChangePasswordAsync([Body] ChangeCredentials credentials);
    }
}

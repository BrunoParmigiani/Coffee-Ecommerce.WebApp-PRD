using Coffee_Ecommerce.WebApp.Features.User.ChangePassword;
using Coffee_Ecommerce.WebApp.Features.User.Create;
using Coffee_Ecommerce.WebApp.Features.User.Delete;
using Coffee_Ecommerce.WebApp.Features.User.GetById;
using Coffee_Ecommerce.WebApp.Features.User.Recovery;
using Coffee_Ecommerce.WebApp.Features.User.Update;

namespace Coffee_Ecommerce.WebApp.Features.User
{
    public interface IUserClient
    {
        [Post("/api/User")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);
        
        [Put("/api/User")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);
        
        [Delete("/api/User")]
        Task<DeleteResult> DeleteAsync();
        
        [Get("/api/User/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);
        
        [Get("/api/User/getinfo")]
        Task<GetByIdResult> GetInfoAsync();
        
        [Put("/api/User/recover")]
        Task<RecoveryResult> RecoverAccountAsync();
        
        [Post("/api/User/changepassword")]
        Task<ChangePasswordResult> ChangePasswordAsync([Body] ChangeCredentials credentials);
    }
}

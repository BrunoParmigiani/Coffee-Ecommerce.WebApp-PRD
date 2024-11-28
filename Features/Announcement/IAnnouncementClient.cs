using Coffee_Ecommerce.WebApp.Features.Announcement.Create;
using Coffee_Ecommerce.WebApp.Features.Announcement.Delete;
using Coffee_Ecommerce.WebApp.Features.Announcement.GetAll;
using Coffee_Ecommerce.WebApp.Features.Announcement.GetById;
using Coffee_Ecommerce.WebApp.Features.Announcement.GetByRole;
using Coffee_Ecommerce.WebApp.Features.Announcement.Update;

namespace Coffee_Ecommerce.WebApp.Features.Announcement
{
    public interface IAnnouncementClient
    {
        [Post("/api/Announcement")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);

        [Delete("/api/Announcement/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);

        [Get("/api/Announcement")]
        Task<GetAllResult> GetAllAsync();

        [Get("/api/Announcement/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);

        [Get("/api/Announcement/user")]
        Task<GetByRoleResult> GetByRoleAsync();

        [Put("/api/Announcement")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);
    }
}

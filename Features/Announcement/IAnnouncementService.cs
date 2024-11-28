using Coffee_Ecommerce.WebApp.Features.Announcement.Create;
using Coffee_Ecommerce.WebApp.Features.Announcement.Update;

namespace Coffee_Ecommerce.WebApp.Features.Announcement
{
    public interface IAnnouncementService
    {
        public Task<AnnouncementEntity?> CreateAsync(CreateRequest request);
        public Task<bool> DeleteAsync(Guid id);
        public Task<List<AnnouncementEntity>?> GetAllAsync();
        public Task<AnnouncementEntity?> GetByIdAsync(Guid id);
        public Task<List<AnnouncementEntity>?> GetByRoleAsync();
        public Task<AnnouncementEntity?> UpdateAsync(UpdateRequest request);
    }
}

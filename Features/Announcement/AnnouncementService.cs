using Coffee_Ecommerce.WebApp.Features.Announcement.Create;
using Coffee_Ecommerce.WebApp.Features.Announcement.Delete;
using Coffee_Ecommerce.WebApp.Features.Announcement.GetAll;
using Coffee_Ecommerce.WebApp.Features.Announcement.GetById;
using Coffee_Ecommerce.WebApp.Features.Announcement.GetByRole;
using Coffee_Ecommerce.WebApp.Features.Announcement.Update;

namespace Coffee_Ecommerce.WebApp.Features.Announcement
{
    public sealed class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementClient _client;
        
        public AnnouncementService(IAnnouncementClient client)
        {
            _client = client;
        }

        public async Task<AnnouncementEntity?> CreateAsync(CreateRequest request)
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

        public async Task<List<AnnouncementEntity>?> GetAllAsync()
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

        public async Task<AnnouncementEntity?> GetByIdAsync(Guid id)
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

        public async Task<List<AnnouncementEntity>?> GetByRoleAsync()
        {
            GetByRoleResult result = new GetByRoleResult();

            try
            {
                result = await _client.GetByRoleAsync();
            }
            catch
            {
                throw;
            }

            return result.Data;
        }

        public async Task<AnnouncementEntity?> UpdateAsync(UpdateRequest request)
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

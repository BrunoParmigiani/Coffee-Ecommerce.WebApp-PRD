using Coffee_Ecommerce.WebApp.Features.Favorite.Create;
using Coffee_Ecommerce.WebApp.Features.Favorite.Delete;
using Coffee_Ecommerce.WebApp.Features.Favorite.GetByUser;
using Coffee_Ecommerce.WebApp.Shared.Events;

namespace Coffee_Ecommerce.WebApp.Features.Favorite
{
    public sealed class FavoriteService : IFavoriteService
    {
        private readonly IFavoriteClient _client;

        public FavoriteService(IFavoriteClient client)
        {
            _client = client;
        }

        public async Task<FavoriteEntity?> CreateAsync(Guid productId)
        {
            CreateResult result = new CreateResult();

            try
            {
                var request = new CreateRequest { ProductId = productId };

                result = await _client.CreateAsync(request);

                ToastRaiser.Notifty("Produto adicionado aos favoritos");
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
                ToastRaiser.Notifty("Produto removido dos favoritos");
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<FavoriteData>?> GetByUserAsync()
        {
            GetByUserResult result = new GetByUserResult();

            try
            {
                result = await _client.GetByUserAsync();
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }
    }
}

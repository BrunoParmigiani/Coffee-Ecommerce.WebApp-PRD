using Coffee_Ecommerce.WebApp.Features.NewOrder;
using Coffee_Ecommerce.WebApp.Features.NewOrder.Create;
using Coffee_Ecommerce.WebApp.Features.NewOrder.Delete;
using Coffee_Ecommerce.WebApp.Features.NewOrder.GetByEstablishment;

namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public sealed class NewOrderService : INewOrderService
    {
        private readonly INewOrderClient _client;
        
        public NewOrderService(INewOrderClient client)
        {
            _client = client;
        }

        public async Task<bool> CreateAsync(Order.Create.CreateRequest request)
        {
            CreateResult result = new();

            var _request = new CreateRequest
            {
                Id = request.Id,
                UserId = request.UserId,
                PaymentMethod = request.PaymentMethod,
                EstablishmentId = request.EstablishmentId,
                Items = request.Items,
                UserName = request.UserName,
                UserAddress = request.UserAddress,
                UserComplement = request.UserComplement
            };

            try
            {
                result = await _client.CreateAsync(_request);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            DeleteResult result = new();

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

        public async Task<List<Create.CreateRequest>> GetByEstablishmentAsync()
        {
            GetByEstablishmentResult result = new();

            try
            {
                result = await _client.GetByEstablishmentAsync();
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }
    }
}

using Coffee_Ecommerce.WebApp.Features.Order.Create;
using Coffee_Ecommerce.WebApp.Features.Order.GetById;
using Coffee_Ecommerce.WebApp.Features.Order.GetByUser;
using Coffee_Ecommerce.WebApp.Features.Order.GetMessages;
using Coffee_Ecommerce.WebApp.Features.Order.GetPage;
using Coffee_Ecommerce.WebApp.Features.Order.Rate;
using Coffee_Ecommerce.WebApp.Features.Order.Update;

namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public sealed class OrderService : IOrderService
    {
        private readonly IOrderClient _client;
        private readonly IOrderMessageClient _messaging;

        public OrderService(IOrderClient client, IOrderMessageClient messaging)
        {
            _client = client;
            _messaging = messaging;
        }

        public async Task<OrderEntity> CreateAsync(CreateRequest request)
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

        public async Task<OrderEntity> GetByIdAsync(Guid id)
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

        public async Task<List<OrderEntity>> GetByUserAsync(GetPageRequest request)
        {
            GetByUserResult result = new GetByUserResult();

            try
            {
                result = await _client.GetByUserAsync(request);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<OrderMessage>> GetMessagesAsync(Guid orderId)
        {
            GetMessagesResult result = new GetMessagesResult();

            try
            {
                result = await _messaging.GetMessagesAsync(orderId);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<List<OrderEntity>> GetPageAsync(GetPageRequest request)
        {
            GetPageResult result = new GetPageResult();

            try
            {
                result = await _client.GetPageAsync(request);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<OrderEntity> RateAsync(RateRequest request)
        {
            RateResult result = new RateResult();

            try
            {
                result = await _client.RateAsync(request);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task<OrderEntity> UpdateAsync(UpdateRequest request)
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

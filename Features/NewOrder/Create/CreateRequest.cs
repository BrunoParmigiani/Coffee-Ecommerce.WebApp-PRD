using Coffee_Ecommerce.WebApp.Features.Order;

namespace Coffee_Ecommerce.WebApp.Features.NewOrder.Create
{
    public sealed class CreateRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int PaymentMethod { get; set; }
        public Guid EstablishmentId { get; set; }
        public OrderItem[] Items { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string UserComplement { get; set; }
    }
}
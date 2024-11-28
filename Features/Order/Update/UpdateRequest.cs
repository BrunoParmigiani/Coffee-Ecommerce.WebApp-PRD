namespace Coffee_Ecommerce.WebApp.Features.Order.Update
{
    public class UpdateRequest
    {
        public Guid Id { get; set; }
        public bool Paid { get; set; }
        public bool Delivered { get; set; }
        public int DeliveryTime { get; set; }
    }
}

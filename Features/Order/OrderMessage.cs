namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public sealed class OrderMessage
    {
        public Guid Sender { get; set; }
        public Guid Receiver { get; set; }
        public Guid Order { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }

        public OrderMessage(Guid sender, Guid receiver, Guid order, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentNullException("Message content cannot be empty");

            Sender = sender;
            Receiver = receiver;
            Order = order;
            Content = content;
        }
    }
}

using Coffee_Ecommerce.WebApp.Features.Product;

namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public class OrderItem : IEquatable<OrderItem>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public Guid Establishment { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(ProductEntity product, int quantity)
        {
            Id = Guid.NewGuid();
            Name = product.Name;
            Price = product.Price;
            Establishment = product.EstablishmentId;
            Quantity = quantity;
        }

        public OrderItem(Guid Id, string Name, float Price, Guid Establishment, int Quantity)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Establishment = Establishment;
            this.Quantity = Quantity;
        }

        public void IncrementQuantity() => Quantity++;
        public void DecrementQuantity()
        {
            Quantity--;

            if (Quantity < 1)
            {
                Quantity = 1;
            }
        }

        public bool Equals(OrderItem? other)
        {
            return other != null && other.Id == Id;
        }
    }
}
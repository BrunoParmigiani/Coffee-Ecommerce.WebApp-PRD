using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Coffee_Ecommerce.WebApp.Features.Order.Create
{
    public sealed class CreateRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public int PaymentMethod { get; set; }
        public Guid EstablishmentId { get; set; }
        public int DeliveryTime { get; set; }
        public OrderItem[] Items { get; set; }
        public bool DeniedOrder { get; set; }

        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string UserComplement { get; set; }

        [MaxLength(500, ErrorMessage = "Motivo não pode ter mais de 500 caracteres")]
        public string? DeniedReason { get; set; }
    }

    public sealed class RequestComparer : IEqualityComparer<CreateRequest>
    {
        public bool Equals(CreateRequest? x, CreateRequest? y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;

            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] CreateRequest obj)
        {
            if (ReferenceEquals(obj, null)) return 0;

            int hashRequestId = obj.Id == Guid.Empty ? 0 : obj.Id.GetHashCode();

            return hashRequestId;
        }
    }
}

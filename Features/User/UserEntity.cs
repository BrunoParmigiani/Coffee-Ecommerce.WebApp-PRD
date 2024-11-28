namespace Coffee_Ecommerce.WebApp.Features.User
{
    public sealed class UserEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Complement { get; set; }

        public string GetFormattedAddress()
        {
            return $"{Street}, {District}, {City} - {State}";
        }
    }
}

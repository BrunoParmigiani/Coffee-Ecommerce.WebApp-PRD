namespace Coffee_Ecommerce.WebApp.Features.Authentication
{
    public sealed class Token
    {
        public bool Authenticated { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expiration { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}

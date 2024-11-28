namespace Coffee_Ecommerce.WebApp.Features.Authentication
{
    public interface IAuthenticationService
    {
        public Task<Token?> LoginAsync(Credentials credentials);
        public Task LogoutAsync();
        public Task<Token?> RefreshAsync(Token token);
        public Task RevokeAsync();
    }
}

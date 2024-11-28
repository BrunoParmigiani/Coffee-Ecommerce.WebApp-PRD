using Coffee_Ecommerce.WebApp.Features.Authentication.Login;
using Coffee_Ecommerce.WebApp.Features.Authentication.Refresh;

namespace Coffee_Ecommerce.WebApp.Features.Authentication
{
    public interface IAuthenticationClient
    {
        [Post("/api/Authentication/signin")]
        Task<LoginResult> LoginAsync([Body] Credentials credentials);

        [Post("/api/Authentication/refresh")]
        Task<RefreshResult> RefreshAsync([Body] Token token);

        [Get("/api/Authentication/revoke")]
        Task RevokeAsync();
    }
}

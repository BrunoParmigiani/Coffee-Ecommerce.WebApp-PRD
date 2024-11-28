using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Coffee_Ecommerce.WebApp.Identity
{
    public sealed class AppIdentityContext
    {
        public string? Role { get; private set; } = null;
        public Guid UserId { get; private set; } = default;

        public AppIdentityContext()
        {
        }

        public async Task RefreshContext(AuthenticationStateProvider provider)
        {
            var state = await provider.GetAuthenticationStateAsync();

            var claims = state.User.Claims;

            Role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value;
            UserId = Guid.Parse(claims.FirstOrDefault(c => c.Type == "UserId").Value);
        }
    }
}

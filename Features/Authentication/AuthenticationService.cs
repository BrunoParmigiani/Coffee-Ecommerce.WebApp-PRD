using Blazored.LocalStorage;
using Coffee_Ecommerce.WebApp.Features.Authentication.Login;
using Coffee_Ecommerce.WebApp.Features.Authentication.Refresh;
using Coffee_Ecommerce.WebApp.Shared.Hubs;
using Microsoft.AspNetCore.Components.Authorization;

namespace Coffee_Ecommerce.WebApp.Features.Authentication
{
    public sealed class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationClient _client;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        private readonly AnnouncementsHub _announcementsHub;
        private readonly OrdersHub _ordersHub;
        private readonly ReportsHub _reportsHub;

        public AuthenticationService(
                IAuthenticationClient client,
                ILocalStorageService localStorage,
                AuthenticationStateProvider authStateProvider,
                AnnouncementsHub announcementsHub, OrdersHub ordersHub,
                ReportsHub reportsHub
            )
        {
            _client = client;
            _localStorage = localStorage;
            _authStateProvider = authStateProvider;

            _announcementsHub = announcementsHub;
            _ordersHub = ordersHub;
            _reportsHub = reportsHub;
        }

        public async Task<Token?> LoginAsync(Credentials credentials)
        {
            LoginResult result = new LoginResult();

            try
            {
                result = await _client.LoginAsync(credentials);
                string token = result.Data.AccessToken;

                await _localStorage.SetItemAsync("token", token);
                await _authStateProvider.GetAuthenticationStateAsync();
            }
            catch (ApiException)
            {
                throw;
            }
            
            return result.Data;
        }

        public async Task LogoutAsync()
        {
            _announcementsHub.CloseConnection();
            _ordersHub.CloseConnection();
            _reportsHub.CloseConnection();

            await _localStorage.RemoveItemAsync("token");
            await _authStateProvider.GetAuthenticationStateAsync();
        }

        public async Task<Token?> RefreshAsync(Token token)
        {
            RefreshResult result = new RefreshResult();

            try
            {
                result = await _client.RefreshAsync(token);
            }
            catch (ApiException)
            {
                throw;
            }

            return result.Data;
        }

        public async Task RevokeAsync()
        {
            try
            {
                await _client.RevokeAsync();
            }
            catch (ApiException)
            {
                throw;
            }
        }
    }
}

using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace Coffee_Ecommerce.WebApp
{
    public sealed class AuthHeaderHandler : DelegatingHandler
    {
        private readonly ILocalStorageService _localStorage;
        private readonly ILogger<AuthHeaderHandler> _logger;
        private readonly IConfiguration _config;

        public AuthHeaderHandler(ILocalStorageService localStorage, ILogger<AuthHeaderHandler> logger, IConfiguration config)
        {
            _localStorage = localStorage;
            _logger = logger;
            _config = config;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string token = await _localStorage.GetItemAsync<string>("token");
            
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (request.RequestUri.ToString().Contains("/api/FooterItem") && request.Method == HttpMethod.Get)
            {
                token = _config.GetValue<string>("apiKey")!;
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}

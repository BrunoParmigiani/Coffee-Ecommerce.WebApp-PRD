using Coffee_Ecommerce.WebApp.Features.Administrator;
using Coffee_Ecommerce.WebApp.Features.Announcement;
using Coffee_Ecommerce.WebApp.Features.Authentication;
using Coffee_Ecommerce.WebApp.Features.Cart;
using Coffee_Ecommerce.WebApp.Features.Establishment;
using Coffee_Ecommerce.WebApp.Features.Favorite;
using Coffee_Ecommerce.WebApp.Features.Footer;
using Coffee_Ecommerce.WebApp.Features.Locator;
using Coffee_Ecommerce.WebApp.Features.NewOrder;
using Coffee_Ecommerce.WebApp.Features.Order;
using Coffee_Ecommerce.WebApp.Features.Product;
using Coffee_Ecommerce.WebApp.Features.Report;
using Coffee_Ecommerce.WebApp.Features.Resume;
using Coffee_Ecommerce.WebApp.Features.User;
using Coffee_Ecommerce.WebApp.Services;
using Coffee_Ecommerce.WebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Coffee_Ecommerce.WebApp
{
    public static class DependencyInjection
    {
        public static void InitializeDependencies(WebAssemblyHostBuilder builder)
        {
            string persistence = builder.Configuration.GetValue<string>("api:persistence")!;
            string communication = builder.Configuration.GetValue<string>("api:communication")!;

            // Refit implementations
            builder.Services.AddRefitClient<IAdministratorClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IAnnouncementClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IAuthenticationClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IEstablishmentClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IFavoriteClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IFooterClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IOrderClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();
            
            builder.Services.AddRefitClient<IProductClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IReportClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();
            
            builder.Services.AddRefitClient<IUserClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<ILocatorClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(communication))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IOrderMessageClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(communication))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IReportMessageClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(communication))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<IResumeClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            builder.Services.AddRefitClient<INewOrderClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(persistence))
                .AddHttpMessageHandler<AuthHeaderHandler>();

            // Application implementations
            builder.Services.AddScoped<IAdministratorService, AdministratorService>();
            builder.Services.AddScoped<IAnnouncementService, AnnouncementService>();
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<IEstablishmentService, EstablishmentService>();
            builder.Services.AddScoped<IFavoriteService, FavoriteService>();
            builder.Services.AddScoped<IFooterService, FooterService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IReportService, ReportService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IAddressService, AddressService>();
            builder.Services.AddScoped<ILocatorService, LocatorService>();
            builder.Services.AddScoped<IResumeService, ResumeService>();
            builder.Services.AddSingleton<INewOrderService, NewOrderService>();
        }
    }
}

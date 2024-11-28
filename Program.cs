using Blazored.LocalStorage;
using Coffee_Ecommerce.WebApp;
using Coffee_Ecommerce.WebApp.Features.Order;
using Coffee_Ecommerce.WebApp.NavBarContext;
using Coffee_Ecommerce.WebApp.Shared.Hubs;
using Coffee_Ecommerce.WebApp.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<NavBarContext>();
builder.Services.AddTransient<AuthHeaderHandler>();
builder.Services.AddSingleton<ReceivedOrders>();
builder.Services.AddSingleton<OrdersHub>();
builder.Services.AddSingleton<ReportsHub>();
builder.Services.AddSingleton<AnnouncementsHub>();
builder.Services.AddSingleton<CfeContext>();

builder.Services.AddAuthorizationCore();

DependencyInjection.InitializeDependencies(builder);

builder.Services.AddBlazoredLocalStorageAsSingleton();

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();

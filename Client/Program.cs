global using BlazorEComm.Shared.Models;
global using System.Net.Http.Json;
global using BlazorEComm.Client.Services.ProductService;
global using BlazorEComm.Client.Services.CategoryService;
global using BlazorEComm.Client.Services.CartService;
global using BlazorEComm.Client.Services.AuthService;
global using BlazorEComm.Client.Services.OrderService;
global using BlazorEComm.Client.Services.AddressService;
global using BlazorEComm.Client.Services.ProductTypeService;
global using BlazorEComm.Client.Services.ProductVariantService;
global using BlazorEComm.Client.Services.ConfigurationService;
global using BlazorEComm.Shared.Constants;
global using BlazorEComm.Shared.Messages;
global using BlazorEComm.Client.Services.AdminService;
global using BlazorEComm.Client.Services.RedirectService;
global using BlazorEComm.Client.Services.ConfigurationAppService;

using BlazorEComm.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IRedirectService, RedirectService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddScoped<IProductVariantService, ProductVariantService>();
builder.Services.AddSingleton<ConfigurationAppDto>();
builder.Services.AddScoped<IConfigurationService, ConfigurationService>();
builder.Services.AddScoped<IConfigurationAppService, ConfigurationAppService>();

await builder.Build().RunAsync();
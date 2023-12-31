global using BlazorEComm.Shared;
global using Microsoft.EntityFrameworkCore;
global using BlazorEComm.Server.Services.ProductService;
global using BlazorEComm.Server.Services.CategoryService;
global using BlazorEComm.Server.Services.CartService;
global using BlazorEComm.Server.Services.PasswordService;
global using BlazorEComm.Server.Services.TokenService;
global using BlazorEComm.Server.Services.AuthService;
global using BlazorEComm.Server.Services.HttpContextService;
global using BlazorEComm.Server.Services.OrderService;
global using BlazorEComm.Server.Data;
global using BlazorEComm.Server.Services.PaymentService;
global using BlazorEComm.Server.Services.AddressService;
global using BlazorEComm.Shared.Settings;
global using BlazorEComm.Server.Services.ProductTypeService;
global using BlazorEComm.Server.Services.ProductVariantService;
global using BlazorEComm.Server.Services.ProductService.Interfaces;
global using BlazorEComm.Server.Services.ConfigurationService;
global using BlazorEComm.Server.Repository;
global using BlazorEComm.Server.Repository.Extensions;
global using BlazorEComm.Server.Repository.Extensions.Interfaces;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<AppSetting>(builder.Configuration.GetSection(AppSetting.Key));
builder.Services.Configure<ConnectionStringsSetting>(builder.Configuration.GetSection(ConnectionStringsSetting.Key));

builder.Services.AddDbContext<EcommDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(ConnectionStringsSetting.DefaultConnectionKey)
));

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IHttpContextService, HttpContextService>();

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddScoped<IAddressExtensionRepository, AddressExtensionRepository>();
builder.Services.AddScoped<ICartExtensionRepository, CartExtensionRepository>();
builder.Services.AddScoped<ICategoryExtensionRepository, CategoryExtensionRepository>();
builder.Services.AddScoped<IConfigurationExtensionRepository, ConfigurationExtensionRepository>();
builder.Services.AddScoped<IOrderExtensionRepository, OrderExtensionRepository>(); 
builder.Services.AddScoped<IProductExtensionRepository, ProductExtensionRepository>();
builder.Services.AddScoped<IProductTypeExtensionRepository, ProductTypeExtensionRepository>(); 
builder.Services.AddScoped<IProductVariantExtensionRepository, ProductVariantExtensionRepository>();
builder.Services.AddScoped<IUserExtensionRepository, UserExtensionRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IConfigurationService, ConfigurationService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IAdminProductService, AdminProductService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddScoped<IProductVariantService, ProductVariantService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => 
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,         
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration[AppSetting.TokenKey])),
        };
    });

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

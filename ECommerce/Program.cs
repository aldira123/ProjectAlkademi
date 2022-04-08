using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using eCommerce.Datas;
using eCommerce.Interface;
using eCommerce.Services;


var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddDbContext<eCommerceDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")))
                // The following three options help with debugging, but should
                // be changed or removed for production.
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );

//Inject
builder.Services.AddScoped<IKategoriService, KategoriService>();
builder.Services.AddScoped<IProdukService, ProdukService>();
builder.Services.AddScoped<IProdukKategoriService, ProdukKategoriService>();
builder.Services.AddScoped<IAkunService, AkunService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IKeranjangService, KeranjangService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAlamatService, AlamatService>();
builder.Services.AddScoped<IStatusService, StatusService>();

builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(
        options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromDays(365);
                options.SlidingExpiration = true;
                options.AccessDeniedPath = "/Home/Denied";
                options.LoginPath = "/Akun/LoginCustomer";
            }
    );

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

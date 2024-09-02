using System.Net;
using TradeLendaInventory.Utility;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout
    options.Cookie.HttpOnly = true; // Make the session cookie HTTP only
    options.Cookie.IsEssential = true; // Make the session cookie essential
});

builder.Services.AddHttpClient("MyClient", c =>
{

    c.BaseAddress = new Uri(builder.Configuration[Constants.Keys.ApiBaseUrl]);
    c.DefaultRequestHeaders.Add("Accept", "application/json");
});
//}).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
//{
//    AllowAutoRedirect = false,
//    AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
//});
var app = builder.Build();

app.UseSession();
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

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=SignIn}/{id?}");

app.Run();

using nba_app.Data;
using nba_app.Models;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddJsonOptions(option =>
    {
        option.JsonSerializerOptions.PropertyNamingPolicy = null;
        option.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });

// add generic api service to container
builder.Services.AddScoped(typeof(IAPIClientService<>), typeof(ApplicationAPIContext<>));


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

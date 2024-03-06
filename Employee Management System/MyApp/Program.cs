// using MyApp.Models;


// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddControllersWithViews();
// builder.Services.AddDbContext<MyApp.Models.SiteDbContext>();

// var app = builder.Build();

// app.UseCors(permissions => permissions.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// app.UseRouting();
// app.MapDefaultControllerRoute();
// app.Run();

using MyApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddAuthentication()
    .AddCookie(option => option.LoginPath = "/HomePage");
builder.Services.AddDbContext<SiteDbContext>(
    options => options.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop4;User ID=dac4;Password=Dac4@1234;Encrypt=False"));
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Ajouter les services de vue
app.Services.AddControllersWithViews();

app.MapGet("/", () => "Hello World!");
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);

app.Run();
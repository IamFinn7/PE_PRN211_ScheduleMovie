var builder = WebApplication.CreateBuilder(args);
// Add-start
builder.Services.AddControllersWithViews();
var app = builder.Build();
// update-Start
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Schedule}/{action=List}/{id?}" 
    );
app.Run();

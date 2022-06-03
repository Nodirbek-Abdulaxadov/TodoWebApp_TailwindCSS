using TodoWebApp_TailwindCSS.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITodoInterface, TodoRepository>();

var app = builder.Build();

app.UseRouting();
app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Todo}/{action=Index}/{id?}"
    );

app.Run();

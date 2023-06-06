using ASPNETMVCCRUD.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MVCDemoDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MvcDemoConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MVCDemoDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MvcDemoConnectionString")));

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
      name: "student_route",
      areaName: "Students",
      pattern: "Student/{controller=Home}/{action=Index}/{id?}"
    ); 
    
    endpoints.MapAreaControllerRoute(
      name: "admin_route",
      areaName: "Admin",
      pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
    );

});

app.Run();
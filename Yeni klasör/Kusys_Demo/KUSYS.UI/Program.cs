using KUSYS.Business.Abstract;
using KUSYS.Business.Concrete;
using KUSYS.Data.Abstract;
using KUSYS.Data.Concrete;
using KUSYS.Data.Concrete.EfCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
// Add services to the container.

builder.Services.AddScoped<ICourseRepository, EfCoreCourseRepository>();
builder.Services.AddScoped<IStudentRepository, EfCoreStudentRepository>();
builder.Services.AddScoped<ICourseService, CourseManager>();
builder.Services.AddScoped<IStudentService, StudentManager>();

builder.Configuration.GetConnectionString("CourseDbContext");
builder.Services.AddTransient<SeedDatabase>();


// Add services to the container.
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

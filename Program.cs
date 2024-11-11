using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MediaManagementSystem.Data; // Đảm bảo thêm using cho DbContext của bạn

var builder = WebApplication.CreateBuilder(args);

// Cấu hình DbContext với SQL Server
builder.Services.AddDbContext<MediaManagementSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MediaManagementSystemContext")));

// Thêm các dịch vụ khác nếu cần
builder.Services.AddControllers();

var app = builder.Build();

// Cấu hình pipeline xử lý HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

using Microsoft.EntityFrameworkCore;
using Template.DAL;

namespace Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>

            options.UseSqlServer("Server=HOME\\SQLEXPRESS; Database= WebData; Trusted_Connection=true; Integrated Security=true; TrustServerCertificate=true;"));
         

            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            app.Run();
        }
    }
}

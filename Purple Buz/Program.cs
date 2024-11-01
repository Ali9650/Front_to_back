using Microsoft.EntityFrameworkCore;
using Purple_Buz.Data;

namespace Purple_Buz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(x=>
            x.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
            );
            var app = builder.Build();
            
            app.UseStaticFiles();
            app.MapDefaultControllerRoute();
            app.Run();
           
        }
    }
}

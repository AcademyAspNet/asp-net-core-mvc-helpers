using MvcHelpersAndFilters.Filters;

namespace MvcHelpersAndFilters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSession();

            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<LogActionFilter>();
            });

            builder.Services.AddScoped<LogActionFilter>();
            builder.Services.AddScoped<AuthFilter>();

            var app = builder.Build();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}");

            app.UseStaticFiles();
            app.UseSession();

            app.Run();
        }
    }
}

using IdentityMiniProject.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace IdentityMiniProject
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                await roleManager.CreateAsync(new IdentityRole("admin"));

                ApplicationUser adminUser = new ApplicationUser()
                {
                    Email = "admin@admin.com",
                    UserName = "admin@admin.com",
                    EmailConfirmed = true

                };
                await userManager.CreateAsync(adminUser, "Ankara1.");
                await userManager.AddToRoleAsync(adminUser, "admin");

            }


            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

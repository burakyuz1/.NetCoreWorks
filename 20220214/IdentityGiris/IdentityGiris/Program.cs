using IdentityGiris.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityGiris
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope()) //service scope'unu uygulama çalýþmadan calistirir.
                                                            //bitince dispose eder
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                //Rol oluþturmak için öncelikle build ve run arasýna user manager ve role manager instencelarý lazým
                //ýdentity user service de default olarak baþlatýlmýþ fakat role ýdentityRole baþlatýlmamýþ.
                //onu service de gidip baþlatýyoruz ( mdolünü ekliyoruz)

                await roleManager.CreateAsync(new IdentityRole("admin")); // admin rolünü oluþturduk.

                ApplicationUser adminUser = new ApplicationUser() // admin userini oluþturduk
                {
                    Email = "admin@example.com",
                    UserName = "admin@example.com",
                    EmailConfirmed = true,
                    DisplayName = "Admin"
                };

                await userManager.CreateAsync(adminUser, "Ankara1."); // parolayý yukarda deðil burada. çünkü hashliyo.
                await userManager.AddToRoleAsync(adminUser, "admin"); // admin user'ýna admin rolünü atýyoruz.
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

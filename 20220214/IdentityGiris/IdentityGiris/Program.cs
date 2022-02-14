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

            using (var scope = host.Services.CreateScope()) //service scope'unu uygulama �al��madan calistirir.
                                                            //bitince dispose eder
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                //Rol olu�turmak i�in �ncelikle build ve run aras�na user manager ve role manager instencelar� laz�m
                //�dentity user service de default olarak ba�lat�lm�� fakat role �dentityRole ba�lat�lmam��.
                //onu service de gidip ba�lat�yoruz ( mdol�n� ekliyoruz)

                await roleManager.CreateAsync(new IdentityRole("admin")); // admin rol�n� olu�turduk.

                ApplicationUser adminUser = new ApplicationUser() // admin userini olu�turduk
                {
                    Email = "admin@example.com",
                    UserName = "admin@example.com",
                    EmailConfirmed = true,
                    DisplayName = "Admin"
                };

                await userManager.CreateAsync(adminUser, "Ankara1."); // parolay� yukarda de�il burada. ��nk� hashliyo.
                await userManager.AddToRoleAsync(adminUser, "admin"); // admin user'�na admin rol�n� at�yoruz.
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

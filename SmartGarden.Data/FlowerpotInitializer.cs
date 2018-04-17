using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SmartGarden.Data
{
    public class FlowerpotInitializer
    {
        public static async System.Threading.Tasks.Task Initialize(FlowerpotContext context, IServiceProvider serviceProvider, IConfiguration configuration)
        {
            UserManager<AppUser> userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = configuration["Data:AdminUser:Name"];
            string email = configuration["Data:AdminUser:Email"];
            string password = configuration["Data:AdminUser:Password"];
            string role = configuration["Data:AdminUser:Role"];

            if (await userManager.FindByNameAsync(username) == null)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }

                AppUser user = new AppUser
                {
                    UserName = username,
                    Email = email
                };

                IdentityResult result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }

            /*if (!context.Flowers.Any())
            {
                context.Flowers.AddRange(
                    new Flower
                    {
                        Name = "Default"
                    },
                    new Flower
                    {
                        Name = "Flower1"
                    }, new Flower
                    {
                        Name = "Flower2"
                    }, new Flower
                    {
                        Name = "Flower3"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Humidities.Any())
            {
                context.Humidities.AddRange(
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 30,
                        FlowerId = 1
                    },
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 40,
                        FlowerId = 2
                    },
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 50,
                        FlowerId = 3
                    },
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 60,
                        FlowerId = 4
                    }
                );
                context.SaveChanges();
            }*/
        }
    }
}

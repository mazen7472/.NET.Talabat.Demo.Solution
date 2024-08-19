using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Identity;

namespace Talabat.Repository.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser()
                {
                    DisplayName = "Mazen Mohamed",
                    Email = "mazen72shahed@gmail.com",
                    UserName = "mazen72shahed",
                    Address = new Address()
                    {
                        FirstName = "Mazen",
                        LastName = "Mohamed",
                        Country = "Egypt",
                        City = "Alexandria",
                        Street = "64 Moustafa Kamel St. , Fleming"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}

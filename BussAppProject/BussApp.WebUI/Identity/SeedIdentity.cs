using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussApp.WebUI.Identity
{
    public class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager,IConfiguration configuration)
        {
            
            var users = configuration.GetSection("UserData:Users");
            foreach (var section in users.GetChildren())
            {
                var userName = section.GetValue<string>("UserName");
                var password = section.GetValue<string>("Password");
                var email = section.GetValue<string>("Email");
                var firstName = section.GetValue<string>("FirstName");
                var lastName = section.GetValue<string>("LastName");

                if (await userManager.FindByNameAsync(userName) == null)
                {
                    var user = new User()
                    {
                        UserName = userName,
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user, password);
                    
                }
            }


        }
    }
}

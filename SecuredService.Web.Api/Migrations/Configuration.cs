using System.Data.Entity.Migrations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SecuredService.Web.Api.Models;

namespace SecuredService.Web.Api.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private void AddUser(AuthContext context)
        {
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(context));
            var user = new IdentityUser
            {
                UserName = "admin"
            };
            if (userManager.FindByName(user.UserName) != null)
            {
                return;
            }

            userManager.Create(user, "password");
        }

        protected override void Seed(AuthContext context)
        {
            AddUser(context);
        }
    }
}
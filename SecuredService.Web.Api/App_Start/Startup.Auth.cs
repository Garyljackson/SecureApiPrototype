using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using SecuredService.Web.Api.Models;
using SecuredService.Web.Api.Providers;

namespace SecuredService.Web.Api
{
    public partial class Startup
    {
        static Startup()
        {
            const string publicClientId = "self";
            UserManagerFactory = () => new UserManager<IdentityUser>(new UserStore<IdentityUser>(new AuthContext()));
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new ApplicationOAuthProvider(publicClientId, UserManagerFactory),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(24)
            };
        }

        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }
        public static Func<UserManager<IdentityUser>> UserManagerFactory { get; set; }

        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}
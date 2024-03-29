﻿using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using SecuredService.Web.Api;

[assembly: OwinStartup(typeof (Startup))]

namespace SecuredService.Web.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);

            ConfigureAuth(app);

            app.UseWebApi(config);
        }
    }
}
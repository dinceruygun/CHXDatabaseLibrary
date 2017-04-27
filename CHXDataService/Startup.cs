﻿using CHXAuthenticate;
using CHXDataService.Authentication;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Nancy;
using Nancy.Conventions;
using Nancy.TinyIoc;
using Owin;
using System;

[assembly: OwinStartup(typeof(CHXDataService.Startup))]

namespace CHXDataService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {


            TinyIoCContainer container = new TinyIoCContainer();

            // Register Dependencies:
            RegisterDependencies(container);

            // Initialize Authentication:
            SetupAuth(app, container);

            // Initialize Nancy:
            SetupNancy(app, container);


            //app
            //.Map("/signalr", map =>
            //{
            //    map.UseCors(CorsOptions.AllowAll);
            //    var hubConfiguration = new HubConfiguration();
            //    map.RunSignalR(hubConfiguration);
            //})
            //.UseNancy();
        }



        private void RegisterDependencies(TinyIoCContainer container)
        {
            // Make some Registrations:
            //container.Register<IMappingProvider, MappingProvider>();
            //container.Register<IConnectionStringProvider, ConnectionStringProvider>();
            //container.Register<IDatabaseFactory, DatabaseFactory>().AsSingleton();
            container.Register<IApplicationSettings, ApplicationSettings>();
            container.Register<ICryptoService, CryptoService>();
            container.Register<IRegistrationService, RegistrationService>();
            container.Register<IHashProvider, HashProvider>();
            container.Register<IAuthenticationService, AuthenticationService>();
        }



        private void SetupAuth(IAppBuilder app, TinyIoCContainer container)
        {
            var settings = container.Resolve<IApplicationSettings>();

            // Use default options:
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions()
            {
                Provider = new OAuthTokenProvider(
                    req => req.Query.Get("bearer_token"),
                    req => req.Query.Get("access_token"),
                    req => req.Query.Get("token"),
                    req => req.Headers.Get("X-Token"))
            });

            // Register a Token-based Authentication for the App:            
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true, // you should use this for debugging only
                TokenEndpointPath = new PathString(settings.TokenEndpointBasePath),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(3000),
                Provider = new SimpleAuthorizationServerProvider(container.Resolve<IAuthenticationService>()),
                RefreshTokenProvider = new SimpleRefreshTokenProvider()
            });
        }



        private void SetupNancy(IAppBuilder app, TinyIoCContainer container)
        {
            var settings = container.Resolve<IApplicationSettings>();

            app.Map(settings.NancyBasePath, siteBuilder => siteBuilder.UseNancy());
            app.Map("", siteBuilder => siteBuilder.UseNancy());
        }

    }






    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("node_modules"));
        }
    }
}

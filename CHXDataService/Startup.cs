using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Nancy;
using Nancy.Conventions;
using Owin;

[assembly: OwinStartup(typeof(CHXDataService.Startup))]

namespace CHXDataService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app
            .Map("/signalr", map =>
            {

                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration();
                map.RunSignalR(hubConfiguration);
            })
            .UseNancy();
        }
    }



    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));
        }
    }
}

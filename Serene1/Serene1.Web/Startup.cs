using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Extensions.DependencyInjection;
using BeerProduction.OPC;

[assembly: OwinStartup(typeof(Serene1.Startup))]

namespace Serene1
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WcfProxy.Client.Startup))]
namespace WcfProxy.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}

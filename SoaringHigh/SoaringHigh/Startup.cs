using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoaringHigh.Startup))]
namespace SoaringHigh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlCreditos.Startup))]
namespace ControlCreditos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

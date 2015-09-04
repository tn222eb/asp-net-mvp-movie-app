using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMovieApp.Startup))]
namespace MyMovieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

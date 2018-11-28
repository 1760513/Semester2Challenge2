using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Semester2Challenge2BasketballApp.Startup))]
namespace Semester2Challenge2BasketballApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

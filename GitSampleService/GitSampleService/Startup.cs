using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitSampleService.Startup))]
namespace GitSampleService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

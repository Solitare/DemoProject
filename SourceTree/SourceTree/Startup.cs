using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SourceTree.Startup))]
namespace SourceTree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

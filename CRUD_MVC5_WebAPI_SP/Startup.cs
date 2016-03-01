using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD_MVC5_WebAPI_SP.Startup))]
namespace CRUD_MVC5_WebAPI_SP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

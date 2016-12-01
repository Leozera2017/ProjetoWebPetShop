using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoWebPetShop.Startup))]
namespace ProjetoWebPetShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

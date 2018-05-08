using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BanDienThoai.Startup))]
namespace BanDienThoai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

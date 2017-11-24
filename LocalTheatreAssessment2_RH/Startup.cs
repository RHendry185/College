using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalTheatreAssessment2_RH.Startup))]
namespace LocalTheatreAssessment2_RH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

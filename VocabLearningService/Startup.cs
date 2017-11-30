using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(VocabLearningService.Startup))]

namespace VocabLearningService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
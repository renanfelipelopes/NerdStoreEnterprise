using Microsoft.Extensions.DependencyInjection;
using NSE.WebApp.MVC.Service;

namespace NSE.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();
        }
    }
}

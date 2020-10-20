using Microsoft.Extensions.DependencyInjection;
using Services;
using System;

namespace Divisores
{
    public class Startup
    {
        public readonly IServiceProvider ServiceProvider;
        public Startup()
        {
            var services = new ServiceCollection();
            this.SetupServiceProvider(services);

            this.ServiceProvider = services.BuildServiceProvider();
        }

        private void SetupServiceProvider(IServiceCollection services)
        {
            services.AddScoped<DivisoresService>();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using GreatFriends.Facade;
using GreatFriends.Module.Home;

namespace GreatFriends
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddLogging();

            services.AddSingleton<IHelloWorld, HelloWorld>();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace WebApplication
{
    public class Startup
    {
       
            public IConfiguration Configuration { get; }
            public Startup(IConfiguration configuration)
            {
                this.Configuration = configuration;
            }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDataList));

            services.AddSingleton(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDataList));


        }


    }

}

using ProjectTasksManagement.Application.Mapping;
using System.Text;
//using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ProjectTasksManagement.Application
{

    public static class ApplicationServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {

            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            //services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<IWeatherService, WeatherService>();

        }
    }
}

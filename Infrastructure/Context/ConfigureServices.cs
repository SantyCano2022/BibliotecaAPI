using Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using UseCases;


namespace Context
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DBbiblioteca"))
            .LogTo(Console.WriteLine, LogLevel.Information)
            );

            services.AddScoped<IApplicationContext, ApplicationContext>();

            services.AddScoped<ITipoMaterialServices,TipoMaterialService>();

            services.AddScoped<IUsuarioServices,UsuarioService>();

            services.AddScoped<IDevolucionServices,DevolucionService>();

            services.AddScoped<IPrestamoServices, PrestamoService>();

            services.AddScoped<IMaterialServices,MaterialService>();

            services.AddScoped<IRolServices,RolService>();



            services.AddHttpClient();

            return services;
        }
    }
}

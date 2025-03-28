using BankingSystem.Modules.Bank.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankingSystem.Modules.Bank.Infrastructure
{
    public static class DependencyInjection
    {
        // Metodo de extension para configurar la inyeccion de dependencia
        public static IServiceCollection AddDependencyInjectionIF(this IServiceCollection services, IConfiguration configuration) 
        {

            /* Variable para acceder los valores de la cadena de conexion con la ayuda de
             * IConfiguration configuration
            */
            var connectionDbString = configuration["ConnectionStrings:ConnectionDb"];

            /* Registra el DbContext en la inyeccion de dependencia y
             * Configura el SQL Server como la base de datos
            */
            services.AddDbContext<BankDbContext>(o =>
                o.UseSqlServer(connectionDbString, option =>
                    option.MigrationsAssembly(typeof(BankDbContext).Assembly.GetName().Name)
                )
            );

            // Retorna los servicios
            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Thomas.Greg.Aplicacao.Aplicacao;
using Thomas.Greg.Aplicacao.Interfaces.API;
using Thomas.Greg.Aplicacao.Interfaces.Repository;
using Thomas.Greg.Data.NHibernateData.Repository;

namespace Thomas.Greg.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IClienteApplication, ClienteApplication>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}

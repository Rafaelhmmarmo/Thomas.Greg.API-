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
            services.AddScoped<IClienteAplicacao, ClienteAplicacao>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ILogradouroAplicacao, LogradouroAplicacao>();
            services.AddScoped<ILogradouroRepository, LogradouroRepository>();
            services.AddScoped<IDbAplicacao, DbAplicacao>();
            services.AddScoped<IDbRepository, DbRepository>();
            services.AddScoped<IAcessoAplicacao, AcessoAplicacao>();

            return services;
        }
    }
}

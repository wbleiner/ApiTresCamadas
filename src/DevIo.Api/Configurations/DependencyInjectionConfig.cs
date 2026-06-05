using DevIo.Business.Interfaces;
using DevIo.Business.Notificacoes;
using DevIo.Business.Services;
using DevIo.Data.Context;
using DevIo.Data.Repository;

namespace DevIo.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Data
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            
            //Business
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();

            return services;
        }
    }
}

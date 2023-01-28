using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopShowcase.Common.Factories;
using ShopShowcase.Data;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.InjectionTypes;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ShopShowcase.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCustomDb(configuration);
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddLogging();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(BaseFactory<,>), typeof(BaseFactory<,>));
            services.AddTransient(typeof(IBaseService<,,,>), typeof(BaseService<,,,>));
            //services.AddServices();
        }

        private static void AddCustomDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options
                .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                .LogTo(message => File.AppendAllText(Path.Combine(Assembly.GetExecutingAssembly().Location, @"..\..\..\..\logs.txt"), message)));
        }

        private static void AddServices(this IServiceCollection services)
        {
            var serviceInterfaceType = typeof(IService);
            var serviceSingletonInterfaceType = typeof(ISingletonService);
            var serviceScopedInterfaceType = typeof(IScopedService);
            var types = serviceInterfaceType.Assembly
                .GetExportedTypes()
                .Where(x => x is { IsClass: true, IsAbstract: false })
                .Select(x => new
                {
                    Service = x.GetInterface($"I{x.Name}"),
                    Implementation = x
                })
                .Where(x => x.Service != null);

            foreach (var type in types)
            {
                if (serviceInterfaceType.IsAssignableFrom(type.Service))
                {
                    services.AddTransient(type.Service, type.Implementation);
                }
                else if (serviceSingletonInterfaceType.IsAssignableFrom(type.Service))
                {
                    services.AddSingleton(type.Service, type.Implementation);
                }
                else if (serviceScopedInterfaceType.IsAssignableFrom(type.Service))
                {
                    services.AddScoped(type.Service, type.Implementation);
                }
            }
        }
    }
}

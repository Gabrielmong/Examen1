using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Evaluacion1.Infrastructure.Contracts.Context;
using Evaluacion1.Infrastructure.Implementations.Contexts;

namespace Evaluacion1.Infrastructure {
    public static class Injection {

        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDBContext, ApplicationDBContext>(options => options.GetService<ApplicationDBContext>());

            // services.AddUnitOfWork<ApplicationDBContext>().AddRepository<Student, StudentRepository>();
            return services;
        }

    }
}
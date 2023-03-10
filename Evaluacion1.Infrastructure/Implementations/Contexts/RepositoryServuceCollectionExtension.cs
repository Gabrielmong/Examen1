﻿using Evaluacion1.Infrastructure.Contracts.Context;
using Evaluacion1.Infrastructure.Implementations.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Evaluacion1.Infrastructure.Implementations.Contexts {
    public static class RepositoryServiceCollectionExtension {
        public static IServiceCollection AddRepository<TEntity, TRepository>(this IServiceCollection services)
        where TEntity : class where TRepository : class, IRepository<TEntity> {
            services.AddScoped<IRepository<TEntity>, TRepository>();
            return services;
        }
        public static IServiceCollection AddUnitOfWork<TContext>(this IServiceCollection services)
        where TContext : DbContext {
            services.AddScoped<IUnitOfWork<TContext>, UnitOfWork<TContext>>();
            return services;
        }
    }
}

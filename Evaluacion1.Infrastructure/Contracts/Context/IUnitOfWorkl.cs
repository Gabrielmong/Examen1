using Microsoft.EntityFrameworkCore;

namespace Evaluacion1.Infrastructure.Contracts.Context {
    public interface IUnitOfWork<T> where T : DbContext {
        T Context { get; }
        void Save();
        IRepository<TEntity> Respository<TEntity>()
            where TEntity : class;
    }
}

using Evaluacion1.Infrastructure.Contracts.Context;
using Evaluacion1.Infrastructure.Implementations.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Evaluacion1.Infrastructure.Contracts.Repositories {
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext {
        public UnitOfWork(T context) {
            _context = context;
            _repositories = new Dictionary<string, object>();
        }
        readonly T _context;
        IDictionary<string, object> _repositories;
        public T Context {
            get { return _context; }
        }
        public void Save() {
            _context.SaveChanges();
        }
        public IRepository<TEntity> Respository<TEntity>()
            where TEntity : class {
            var repository = _context.GetService<IRepository<TEntity>>();
            if (repository != null) {
                return repository;
            }
            var type = typeof(TEntity);
            var typeName = type.Name;
            if (_repositories.ContainsKey(typeName)) {
                return (IRepository<TEntity>)_repositories[typeName];
            }
            var instance = new Repository<TEntity>(_context);
            _repositories.Add(typeName, instance);
            return instance;
        }
    }
}

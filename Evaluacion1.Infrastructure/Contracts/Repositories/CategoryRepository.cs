using Evaluacion1.Infrastructure.Implementations.Contexts;
using Evaluacion1.Models.EntityModels;

namespace Evaluacion1.Infrastructure.Contracts.Repositories {
    internal class CategoryRepository : Repository<Category> {
        public CategoryRepository(ApplicationDBContext context) : base(context) {
        }
    }
}


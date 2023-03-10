using Evaluacion1.Infrastructure.Implementations.Contexts;
using Evaluacion1.Models.EntityModels;

namespace Evaluacion1.Infrastructure.Contracts.Repositories {
    internal class AuthorRepository: Repository<Author> {
        public AuthorRepository(ApplicationDBContext context) : base(context) {
        }
    }
}

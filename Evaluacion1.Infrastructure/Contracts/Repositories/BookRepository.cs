using Evaluacion1.Infrastructure.Implementations.Contexts;
using Evaluacion1.Models.EntityModels;

namespace Evaluacion1.Infrastructure.Contracts.Repositories {
    internal class BookRepository : Repository<Book> { 
        public BookRepository(ApplicationDBContext context) : base(context) {
        }
    }
}


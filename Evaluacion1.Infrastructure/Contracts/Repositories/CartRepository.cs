using Evaluacion1.Infrastructure.Implementations.Contexts;
using Evaluacion1.Models.EntityModels;

namespace Evaluacion1.Infrastructure.Contracts.Repositories {
    public class CartRepository : Repository<Cart> {
        public CartRepository(ApplicationDBContext context) : base(context) {
        }
    }
}
    

using Evaluacion1.Infrastructure.Contracts.Context;
using Evaluacion1.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.Infrastructure.Implementations.Contexts {
    public class ApplicationDBContext : DbContext, IApplicationDBContext {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
        }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cart> Carts { get; set; }
    }
}

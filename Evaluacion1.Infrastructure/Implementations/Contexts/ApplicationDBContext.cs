using Evaluacion1.Infrastructure.Contracts.Context;
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
        public DbSet<Student> Students { get; set; }

        public DbSet<DBPokemon> Pokemons { get; set; }
    }
}

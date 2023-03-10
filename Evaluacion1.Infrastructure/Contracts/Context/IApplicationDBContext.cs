using Evaluacion1.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.Infrastructure.Contracts.Context {
    public interface IApplicationDBContext {

        DbSet<Author> Authors { get; set; }

        DbSet<Book> Books { get; set; }

        DbSet<Category> Categories { get; set; }

        
    }
}

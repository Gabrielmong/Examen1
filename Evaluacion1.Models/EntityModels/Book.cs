using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.Models.EntityModels {
    public class Book {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string ISBN { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(20)]
        public int Price { get; set; }
    }
}

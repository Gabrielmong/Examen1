using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.Models.EntityModels {
    public class Cart {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        [ForeignKey("Book")]
        public int BookId { get; set; }
        
    }
}

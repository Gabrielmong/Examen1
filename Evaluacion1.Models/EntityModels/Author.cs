using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.Models.EntityModels {
    public class Author {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("Phone")]
        public string Phone { get; set; }
    }
}

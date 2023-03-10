using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.Models.EntityModels {
    public class Category {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }
        
    }
}

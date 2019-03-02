using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="El campo {0}es requerido")]
        [MaxLength(50,ErrorMessage ="El campo{0} solo puede tener {1}caracteres de largo")]
        public string Description { get; set; }
    }
}

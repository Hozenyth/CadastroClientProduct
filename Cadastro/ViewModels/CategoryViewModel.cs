using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "O nome da categoria é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int IdCategory { get; set; }
        
        public virtual Category Category { get; set; }

      
    }
}

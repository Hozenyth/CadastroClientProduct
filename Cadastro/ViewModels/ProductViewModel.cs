using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Value")]
        [Required(ErrorMessage = "O valor do produto é requerido")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "O email é requerido.")]
        public string Email { get; set; }

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }
    }
}

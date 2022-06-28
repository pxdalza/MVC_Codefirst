using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CodeFirst.Models
{
    public class Seccion
    {
        [Key]
        [Required]
        public int SeccionId { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "La longitud de caracteres no es el permitido.")]
        public String Codigo { get; set; }
    }
}
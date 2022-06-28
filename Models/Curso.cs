using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CodeFirst.Models
{
    public class Curso
    {
        [Key]
        [Required]
        public int CursoId { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "La longitud de caracteres no es el permitido.")]
        public String Nombre { get; set; }
        [Required]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "La longitud de caracteres no es el permitido.")]
        public String Codigo { get; set; }
    }
}
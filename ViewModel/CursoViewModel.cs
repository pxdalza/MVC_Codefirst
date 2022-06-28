using MVC_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CodeFirst.ViewModel
{
    public class CursoViewModel
    {
        [Required]
        public int CursoId { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre requerido")]
        [Display(Name ="Nombre del Curso:")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "La longitud de caracteres no es el permitido.")]
        public String Nombre { get; set; }

        [Display(Name = "Codigo del Curso:")]
        [Required(ErrorMessage = "Ingrese el codigo requerido")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "La longitud de caracteres no es el permitido.")]
        public String Codigo { get; set; }


        public Curso ConvertToCurso()
        {
            return new Curso { CursoId = this.CursoId, Codigo = this.Codigo, Nombre = this.Nombre };
        }
    }
}
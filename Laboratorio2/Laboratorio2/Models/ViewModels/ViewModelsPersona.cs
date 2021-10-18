using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Models.ViewModels
{
    public class ViewModelsPersona
    {
        [Display(Name = "NombrePersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string NombrePersona { get; set; }


        [Display(Name = "EdadPersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int EdadPersona { get; set; }


        [Display(Name = "DescripcionPersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string DescripcionPersona { get; set; }
    }
}

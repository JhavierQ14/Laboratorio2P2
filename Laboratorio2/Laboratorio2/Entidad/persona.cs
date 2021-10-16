using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Entidad
{
    public class persona
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPersona { get; set; }

        public string NombrePersona { get; set; }

        public int EdadPersona { get; set; }

        public string DescripcionPersona { get; set; }
    }
}

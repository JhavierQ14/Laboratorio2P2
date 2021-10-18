using Laboratorio2.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Servicios
{
     public interface IPersona
    {
            void Save(persona c);

            ICollection<persona> ListarDatos();
        

    }
}

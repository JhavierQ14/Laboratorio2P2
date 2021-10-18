
using Laboratorio2.Data;
using Laboratorio2.Entidad;
using Laboratorio2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Repositorio
{
    public class PersonaRepositorio : IPersona
    {
        private ApplicationDbContext app;

        public PersonaRepositorio(ApplicationDbContext app)
        {
            this.app = app;
        }

        public ICollection<persona> ListarDatos()
        {
            return app.personas.ToList();
        }

        public void Save(persona c)
        {
            app.Add(c);
            app.SaveChanges();


        }
       

    }
}

using Laboratorio2.Entidad;
using Laboratorio2.Models;
using Laboratorio2.Models.ViewModels;
using Laboratorio2.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IPersona ipersona;


        public HomeController(ILogger<HomeController> logger, IPersona ipersona)
        {
            this.ipersona = ipersona;
            _logger = logger;

        }
        // ----------------------------------------------------------------------------------------------------
        public IActionResult MostrarDatos()
        {
            return View();
        }
        //---------------------------------------------------------------------------------------------------------
        
        public IActionResult Save(ViewModelsPersona persona)

        {

            persona per = new persona();

            if (ModelState.IsValid)
            {


                if (persona.EdadPersona >= 18)
                {
                    per.NombrePersona = persona.NombrePersona;
                    per.EdadPersona = persona.EdadPersona;
                    per.DescripcionPersona = persona.DescripcionPersona;

                    ipersona.Save(per);
                    return View("MostrarDatos");


                }
                else
                {
                    return Redirect("/Home/Save");
                }


            }
            else
            {
                return View("Save");

            }
        }
    
        //-------------------------------------------------------------------------------------------------------

        public IActionResult GetAll()
        {

            var DandoFormatoJson = ipersona.ListarDatos();


            return Json(new { data = DandoFormatoJson });
        }


        //-----------------------------------------------------------------------

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

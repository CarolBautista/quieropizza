using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var AlumnosBL = new AlumnosBL();
            var listadeAlumnos = AlumnosBL.ObtenerAlumnos();

            return View(listadeAlumnos);
        }
    }
}
using EducacionAvanzada.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducacionAvanzada.WebAdmin.Controllers
{
    public class SeccionesController : Controller
    {
        SeccionesBL _seccionesBL;

        public SeccionesController()
        {
            _seccionesBL  = new SeccionesBL();
        }

        // GET: Jornadas
        public ActionResult Index()
        {
            var ListadeSecciones = _seccionesBL.ObtenerSecciones();

            return View(ListadeSecciones);
        }

        public ActionResult Crear()
        {
            var nuevaSeccion= new Seccion();

            return View(nuevaSeccion);
        }

        [HttpPost]
        public ActionResult Crear(Seccion seccion)
        {
            if (ModelState.IsValid)
            {
                if (seccion.Descripcion != seccion.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "No debe haber espacios al inicio o al final");
                    return View(seccion);
                }
                _seccionesBL.GuardarSeccion(seccion);

                return RedirectToAction("Index");
            }

            return View(seccion);

        }

        public ActionResult Editar(int id)
        {
            var seccion = _seccionesBL.ObtenerSecciones(id);


            return View(seccion);
        }
  
        [HttpPost]
        public ActionResult Editar(Seccion seccion)
        {
            _seccionesBL.GuardarSeccion(seccion);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var seccion= _seccionesBL.ObtenerSecciones(id);

            return View(seccion);
        }

        public ActionResult Eliminar(int id)
        {
            var seccion = _seccionesBL.ObtenerSecciones(id);

            return View(seccion);
        }

        [HttpPost]
        public ActionResult Eliminar(Seccion seccion)
        {
            _seccionesBL.EliminarSeccion(seccion.Id);

            return RedirectToAction("Index");
        }
    }
}
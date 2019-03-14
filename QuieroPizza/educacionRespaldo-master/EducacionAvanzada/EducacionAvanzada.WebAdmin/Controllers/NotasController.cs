using EducacionAvanzada.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducacionAvanzada.WebAdmin.Controllers
{
    public class NotasController : Controller

    {
        NotasBL _notasBL;
     

        public NotasController()
        {
            _notasBL = new NotasBL();
        
           
        }
        // GET: Notas
        public ActionResult Index()
        {

            var listadeNotas = _notasBL.ObtenerNota();
       

            return View(listadeNotas);
        }
        public ActionResult Crear()
        {

            var nuevaNota = new Notas();


            return View(nuevaNota);
        }

  

        
    }
}
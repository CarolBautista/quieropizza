using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionAvanzada.BL
{
    public class SeccionesBL
    {

        Contexto _contexto;
        public List<Seccion> Listadesecciones { get; set; }

        public SeccionesBL()
        {
            _contexto = new Contexto();
            Listadesecciones = new List<Seccion>();
        }
        public List<Seccion> ObtenerSecciones()
        {
            Listadesecciones = _contexto.Seccion.ToList();
         
            return Listadesecciones;

        }

        public object ObtenerSecciones(int id)
        {
            throw new NotImplementedException();
        }

        public void GuardarSeccion(Seccion seccion)
        {
            if (seccion.Id == 0)
            {
                _contexto.Seccion.Add(seccion);
            }
            else
            {
                var seccionExistente = _contexto.Seccion.Find(seccion.Id);
                seccionExistente.Descripcion = seccion.Descripcion;
            }

            _contexto.SaveChanges();
        }

        public Seccion ObtenerSeccion(int id)
        {
            var seccion = _contexto.Seccion.Find(id);

            return seccion;
        }

        public void EliminarSeccion(int id)
        {
            var seccion = _contexto.Seccion.Find(id);

            _contexto.Seccion.Remove(seccion);
            _contexto.SaveChanges();
        }
    }
}

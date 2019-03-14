using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionAvanzada.BL
{
    public class NotasBL
    {
        Contexto _contexto;
        public List<Notas> ListadeNota { get; set; }

        public NotasBL()
        {
            _contexto = new Contexto();
            ListadeNota = new List<Notas>();
        }
        public List<Notas> ObtenerNota()
        {
            ListadeNota = _contexto.Notas
            .Include("Alumno")
            .ToList();

            return ListadeNota;
        }

        public void GuardarNota(Notas nota)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionAvanzada.BL
{
    public class Notas
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        public int IdGrado { get; set; }
        public Grado Grado { get; set; }

        public int IdJornada { get; set; }
        public Jornada Jornada { get; set; }

        public int IdSeccion { get; set; }
        public Seccion seccion { get; set; }

       

        public List<NotasDetalle> ListadeNotasDetalle { get; set; }

        public Notas()
        {
            ListadeNotasDetalle = new List<NotasDetalle>();
        }
    }

    public class NotasDetalle
    {
        public int Id { get; set; }

        public int NotaId { get; set; }
        public Notas Notas { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        public int MateriaId { get; set; }
        public materia materia { get; set; }

        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int TercerParcial { get; set; }
        public int CuartoParcial { get; set; }

        public int NotaFinal { get; set; }

    }
}


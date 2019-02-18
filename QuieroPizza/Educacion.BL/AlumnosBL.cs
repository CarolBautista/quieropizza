using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
    public class AlumnosBL
    {

      public  List<Alumno> ObtenerAlumnos()
        {
            var Alumno1 = new Alumno();
            Alumno1.Id = 1;
            Alumno1.Nombre = "Juan";
            Alumno1.Jornada = "Matutina";
            Alumno1.grado = "Sexto";
            Alumno1.Seccion = "A";

            var Alumno2 = new Alumno();
            Alumno2.Id = 2;
            Alumno2.Nombre = "Carolina ";
            Alumno2.Jornada = "Matutina";
            Alumno2.grado = "Sexto";
            Alumno2.Seccion = "A";

            var Alumno3 = new Alumno();
            Alumno3.Id = 1;
            Alumno3.Nombre = "Rosa";
            Alumno1.Jornada = "Vespertina";
            Alumno3.grado = "Quinto";
            Alumno3.Seccion = "A";

            var listadeAlumnos = new List<Alumno>();
            listadeAlumnos.Add(Alumno1);
            listadeAlumnos.Add(Alumno2);
            listadeAlumnos.Add(Alumno3);

            return listadeAlumnos;
        }
    }
}

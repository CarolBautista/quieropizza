using Educacion.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educacion.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          var alumnosBL =  new AlumnosBL();
            var listadeAlumnos = alumnosBL.ObtenerAlumnos();

            foreach (var alumno in listadeAlumnos)
            {
                MessageBox.Show(alumno.Nombre);
            }
        }
    }
}

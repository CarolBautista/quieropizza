﻿using Educacion.BL;
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
            var alumnosBL = new AlumnosBL();
            var listadeAlumnos = alumnosBL.ObtenerAlumnos();

            listadeAlumnosBindingSource.DataSource = listadeAlumnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void listadeAlumnosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

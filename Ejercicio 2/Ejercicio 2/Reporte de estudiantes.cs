using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Reporte_de_estudiantes : Form
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        private int edit_indice = -1;

        


        public Reporte_de_estudiantes()
        {
            InitializeComponent();
        }
    }
}

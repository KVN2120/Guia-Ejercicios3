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
    public partial class Form3 : Form
    {
        public List<Alumno> AlumnoRecibe = null; //creación de una lista que reciba
        
        public Form3()
        {
            InitializeComponent();
        }
        private void actualizarGrid()
        {
            dgvlistadoestudiantes.DataSource = null;
            dgvlistadoestudiantes.DataSource = AlumnoRecibe;
        }

       

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnllenar_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }


    }
}

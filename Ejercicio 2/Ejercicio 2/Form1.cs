using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgvdatoestudiante.DataSource = null;
            dgvdatoestudiante.DataSource = Alumnos;
        }
        

       
        public Form1()
        {
            InitializeComponent();
        }
        String entrada = "";
        
        private void btnañadir_Click(object sender, EventArgs e)
        {
            entrada =Interaction.InputBox("Numero de estudiantes", "Estudiantes");

            

            listelementos.Items.Add(entrada);
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            
            Form formulario = new Form2();
            formulario.Show();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            Alumno alum = new Alumno();
            alum.Carnet = Text;
            alum.Nombre = Text;
            alum.Apellido = Text;
            alum.Materia = Text;
            alum.Nota1 = Text;
            alum.Nota2 = Text;
            alum.Nota3 = Text;

            this.Hide();
            actualizarGrid();
            Form2 formulario = new Form2();
            
            formulario.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       
        


         }
}

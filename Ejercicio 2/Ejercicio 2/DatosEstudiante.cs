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
    public partial class Form2 : Form
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgvdatoestudiante.DataSource = null;
            dgvdatoestudiante.DataSource = Alumnos;
        }

        private void limpiar()
        {
            txtcarnet.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtmateria.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
        }

       

        
        public Form2()
        {
            InitializeComponent();
        }
         
        private void dgvdatoestudiante_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvdatoestudiante.SelectedRows[0];
            int posicion = dgvdatoestudiante.Rows.IndexOf(selected);
            edit_indice = posicion;

            Alumno alum = Alumnos[posicion];

            txtcarnet.Text = alum.Carnet;
            txtnombre.Text = alum.Nombre;
            txtapellido.Text = alum.Apellido;
            txtmateria.Text = alum.Materia;
            txtnota1.Text = alum.Nota1;
            txtnota2.Text = alum.Nota2;
            txtnota3.Text = alum.Nota3;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Alumno alum = new Alumno();
            alum.Carnet = txtcarnet.Text;
            alum.Nombre = txtnombre.Text;
            alum.Apellido = txtapellido.Text;
            alum.Materia = txtmateria.Text; 
            alum.Nota1 = txtnota1.Text;
            alum.Nota2 = txtnota2.Text;
            alum.Nota3 = txtnota3.Text;

            string nota1, nota2, nota3, prom;

            nota1 = txtnota1.Text;
            nota2 = txtnota2.Text;
            nota3 = txtnota3.Text;



            

            if (edit_indice > -1)
            {
                Alumnos[edit_indice] = alum;
                edit_indice = -1;
            }
            else
            {
                Alumnos.Add(alum);
            }
            actualizarGrid();
            limpiar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 formulario = new Form3();
            formulario.AlumnoRecibe = Alumnos;
            formulario.Show();

        }

       

        
    }
}

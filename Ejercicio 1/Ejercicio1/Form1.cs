using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private List<CuentaBanco> Cuentas = new List<CuentaBanco>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Cuentas;
        }
        private void limpiar()
        {
            txtdui.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtnit.Clear();
            txtmonto.Clear();
            txtnumerocuenta.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected);
            edit_indice = posicion;

            CuentaBanco cuentabanc = Cuentas[posicion];

            txtdui.Text = cuentabanc.Dui;
            txtnombre.Text = cuentabanc.Nombre;
            txtapellido.Text = cuentabanc.Apellido;
            txtnit.Text = cuentabanc.Nit;
            txtmonto.Text = cuentabanc.MontoDisponible;
            txtnumerocuenta.Text = cuentabanc.NumeroCuenta;
            tipodecuenta.Text = cuentabanc.TipoDeCuenta;
            sucursal.Text = cuentabanc.Sucursal;
      
        }

        
        private void btnguardar_Click(object sender, EventArgs e)
        {
            CuentaBanco cuentabanc = new CuentaBanco();
            cuentabanc.Dui = txtdui.Text;
            cuentabanc.Nombre = txtnombre.Text;
            cuentabanc.Apellido = txtapellido.Text;
            cuentabanc.Nit = txtnit.Text;
            cuentabanc.MontoDisponible = txtmonto.Text;
            cuentabanc.TipoDeCuenta = tipodecuenta.Text;
            cuentabanc.NumeroCuenta = txtnumerocuenta.Text;
           
            cuentabanc.Sucursal = sucursal.Text;

            if (rdbahorro.Checked == true)
            {
                cuentabanc.TipoDeCuenta = "Cuenta de Ahorro (CA-)";
            }

            if( rdbcorriente.Checked == true)
            {
                cuentabanc.TipoDeCuenta = "Cuenta Corriente (CO-)";
            }

            if (rdbplazos.Checked == true)
            {
                cuentabanc.TipoDeCuenta = "Cuenta a Plazos (CP-)";
            }

            if (rdbsansalvador.Checked == true)
            {
                cuentabanc.Sucursal = "San Salvador";
            }

            if (rdbsanmiguel.Checked == true)
            {
                cuentabanc.Sucursal = "San Miguel";
            }

            if(rdbsantaana.Checked == true)
            {
                cuentabanc.Sucursal = "Santa Ana";
            }

            if (rdblalibertad.Checked == true)
            {
                cuentabanc.Sucursal = "La Libertad";
            }

            if (rdbmorazan.Checked == true)
            {
                cuentabanc.Sucursal = "Morazan";
            }

            if (edit_indice > -1)
            {
                Cuentas[edit_indice] = cuentabanc;
                edit_indice = -1;
            }
            else
            {
                Cuentas.Add(cuentabanc);
            }
            actualizarGrid();
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Cuentas.RemoveAt(edit_indice);
                edit_indice = -1;
                actualizarGrid();
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre contacto");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}

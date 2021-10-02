using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class CuentaBanco
    {
        private string dui;
        private string nombre;
        private string apellido;
        private string nit;
        private string montodisponible;
        private string numerocuenta;
        private string tipodecuenta;
        private string sucursal;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public string Nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public string MontoDisponible
        {
            get { return montodisponible; }
            set { montodisponible = value; }
        }
        public string NumeroCuenta
        {
            get { return numerocuenta; }
            set { numerocuenta = value; }
        }
        public string TipoDeCuenta
        {
            get { return tipodecuenta; }
            set { tipodecuenta = value; }
        }
        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
    }
}

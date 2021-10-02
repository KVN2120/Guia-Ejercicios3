using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Alumno
    {
        string carnet;
        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        string materia;
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        float[] calificaciones = new float[3];
        public float[] Calificaciones
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }
        string nota1;
        public string Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        string nota2;
        public string Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        
        string nota3;
        public string Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }
        string promedio;

        public string Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

    }
}

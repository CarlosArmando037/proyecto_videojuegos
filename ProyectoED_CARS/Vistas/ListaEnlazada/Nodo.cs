using ProyectoED_CARS.Clases;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoED_CARS.Vistas.ListaEnlazada
{
    public class Nodo
    {
        private string _nombre;
        private int _precio;
        private string _genero;
        private string _consola;
        private Nodo _siguiente;



        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }


        public string Consola
        {
            get { return _consola;}
            set { _consola = value; }
        }


        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}

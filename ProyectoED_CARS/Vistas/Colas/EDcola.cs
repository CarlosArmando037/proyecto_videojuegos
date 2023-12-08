using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ProyectoED_CARS.Vistas.Colas;
using ProyectoED_CARS.Vistas.ListaEnlazada;

namespace ProyectoED_CARS
{
    public partial class EDcola : Form
    {

        NodoCola Primero = new NodoCola();
        NodoCola Ultimo = new NodoCola();

        public EDcola()
        {
            Primero = null;
            Ultimo = null;

            InitializeComponent();
        }

        public void Insertar()
        {
            NodoCola nuevo = new NodoCola();

            nuevo.Nombre = Convert.ToString(textNombre.Text);
            nuevo.Precio = Convert.ToInt32(textPrecio.Text);
            nuevo.Genero = Convert.ToString(textGenero.Text);
            nuevo.Consola = Convert.ToString(textConsola.Text);


            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                Ultimo = nuevo;
            }
        }


        public void Mostrar()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Precio";
            dataGridView1.Columns[2].Name = "Genero";
            dataGridView1.Columns[3].Name = "Consola";
            NodoCola Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    dataGridView1.Rows.Add(Actual.Nombre, Actual.Precio, Actual.Genero, Actual.Consola);

                    Actual = Actual.Siguiente;
                }
            }

        }

        

        public void Modificar()
        {
            NodoCola actual = Primero;

            bool Encontrado = false;

            string nodoBuscado = Convert.ToString(textNombreModificar.Text);
            if (Primero != null)
            {
                while (actual != null && Encontrado != true)
                {
                    if (actual.Nombre == nodoBuscado)
                    {
                        actual.Nombre = Convert.ToString(textNombre.Text);
                        actual.Precio = Convert.ToInt32(textPrecio.Text);
                        actual.Genero = Convert.ToString(textGenero.Text);
                        actual.Consola = Convert.ToString(textConsola.Text);


                        Encontrado = true;
                    }
                    actual = actual.Siguiente;
                }
                if (!Encontrado)
                {
                    MessageBox.Show("No se encontró");
                }
            }
            else
            {
                MessageBox.Show("La cola esta vacia");
            }
        }


        public void Eliminar()
        {
            NodoCola actual = new NodoCola();
            actual = Primero;
            NodoCola anterior = new NodoCola();
            anterior = null;

            bool Encontrado = false;
            string nodoBuscado = Convert.ToString(textNombreModificar.Text);

            if (Primero != null)
            {
                while (actual != null && Encontrado != true)
                {
                    if (actual.Nombre == nodoBuscado)
                    {
                        actual.Nombre = Convert.ToString(textNombre.Text);
                        actual.Precio = Convert.ToInt32(textPrecio.Text);
                        actual.Genero = Convert.ToString(textGenero.Text);
                        actual.Consola = Convert.ToString(textConsola.Text);


                        if (actual == Primero)
                        {
                            Primero = Primero.Siguiente;

                        }
                        else if (actual == Ultimo)
                        {
                            anterior.Siguiente =  null;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                        }
                        Encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                if (!Encontrado)
                {
                    MessageBox.Show("Elemento no encontrado");
                }
            }
        }


        public void OrdenarAscendente()
        {
            if (Primero == null || Primero.Siguiente == null)
            {
                // No hay elementos o solo hay un elemento.
                return;
            }

            NodoCola actual = Primero;
            NodoCola siguiente = Primero.Siguiente;

            while (actual != null)
            {
                while (siguiente != null)
                {
                    if (string.Compare(actual.Nombre, siguiente.Nombre) > 0)
                    {
                        
                        NodoCola temp = new NodoCola
                        {
                            Nombre = actual.Nombre,
                            Precio = actual.Precio,
                            Genero = actual.Genero,
                            Consola = actual.Consola
                        };

                        actual.Nombre = siguiente.Nombre;
                        actual.Precio = siguiente.Precio;
                        actual.Genero = siguiente.Genero;
                        actual.Consola = siguiente.Consola;

                        siguiente.Nombre = temp.Nombre;
                        siguiente.Precio = temp.Precio;
                        siguiente.Genero = temp.Genero;
                        siguiente.Consola = temp.Consola;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
                if (actual != null)
                {
                    siguiente = actual.Siguiente;
                }
            }
        }

        public void OrdenarDescendente()
        {
            if (Primero == null || Primero.Siguiente == null)
            {
                // No hay elementos o solo hay un elemento.
                return;
            }

            NodoCola actual = Primero;
            NodoCola siguiente = Primero.Siguiente;

            while (actual != null)
            {
                while (siguiente != null)
                {
                    if (string.Compare(actual.Nombre, siguiente.Nombre) < 0)
                    {
                        NodoCola temp = new NodoCola
                        {
                            Nombre = actual.Nombre,
                            Precio = actual.Precio,
                            Genero = actual.Genero,
                            Consola = actual.Consola
                        };

                        actual.Nombre = siguiente.Nombre;
                        actual.Precio = siguiente.Precio;
                        actual.Genero = siguiente.Genero;
                        actual.Consola = siguiente.Consola;

                        siguiente.Nombre = temp.Nombre;
                        siguiente.Precio = temp.Precio;
                        siguiente.Genero = temp.Genero;
                        siguiente.Consola = temp.Consola;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
                if (actual != null)
                {
                    siguiente = actual.Siguiente;
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar();
            Mostrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Mostrar();
        }

        private void btnAcendente_Click(object sender, EventArgs e)
        {
            OrdenarAscendente();
            Mostrar();
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            OrdenarDescendente();
            Mostrar();
        }
    }
}

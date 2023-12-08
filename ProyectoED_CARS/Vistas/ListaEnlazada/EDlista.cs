using ProyectoED_CARS.Vistas.ListaEnlazada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoED_CARS
{
    public partial class EDlista : Form
    {
        Nodo Primero = new Nodo();
        Nodo Ultimo = new Nodo();

        public EDlista()
        {

            Primero = null;
            Ultimo = null;

            InitializeComponent();
        }



        public void Insertar()
        {
            Nodo nuevo = new Nodo();

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
            Nodo Actual = Primero;

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
            Nodo actual = Primero;

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
        }


        public void EliminarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;

            bool Encontrado = false;
            string nodoBuscado = Convert.ToString(textNombreModificar.Text);
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Nombre == nodoBuscado)
                    {

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    MessageBox.Show("No se encontró");
                }
            }

        }



        public void OrdenarAcendente()
        {
            if (Primero == null || Primero.Siguiente == null)
            {
                return;
            }

            bool intercambio;
            do
            {
                intercambio = false;
                Nodo actual = Primero;
                Nodo siguiente = Primero.Siguiente;
                Nodo anterior = null;

                while (siguiente != null)
                {
                    if (string.Compare(actual.Nombre, siguiente.Nombre) > 0)
                    {
                        
                        intercambio = true;
                        if (anterior != null)
                        {
                            anterior.Siguiente = siguiente;
                        }
                        else
                        {
                            Primero = siguiente;
                        }

                        actual.Siguiente = siguiente.Siguiente;
                        siguiente.Siguiente = actual;

                        Nodo temp = actual;
                        actual = siguiente;
                        siguiente = temp;
                    }

                    anterior = actual;
                    actual = actual.Siguiente;
                    siguiente = siguiente.Siguiente;
                }
            } while (intercambio);
        }

        public void OrdenarDescendente()
        {
            if (Primero == null || Primero.Siguiente == null)
            {
                return;
            }

            bool intercambio;
            do
            {
                intercambio = false;
                Nodo actual = Primero;
                Nodo siguiente = Primero.Siguiente;
                Nodo anterior = null;

                while (siguiente != null)
                {
                    if (string.Compare(actual.Nombre, siguiente.Nombre) < 0)
                    {
                        
                        intercambio = true;
                        if (anterior != null)
                        {
                            anterior.Siguiente = siguiente;
                        }
                        else
                        {
                            Primero = siguiente;
                        }

                        actual.Siguiente = siguiente.Siguiente;
                        siguiente.Siguiente = actual;

                        Nodo temp = actual;
                        actual = siguiente;
                        siguiente = temp;
                    }

                    anterior = actual;
                    actual = actual.Siguiente;
                    siguiente = siguiente.Siguiente;
                }
            } while (intercambio);
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void textNombreModificar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarNodo();
            Mostrar();
        }

        private void btnAcendente_Click(object sender, EventArgs e)
        {
            OrdenarAcendente();
            Mostrar();
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            OrdenarDescendente();
            Mostrar();
        }
    }
}

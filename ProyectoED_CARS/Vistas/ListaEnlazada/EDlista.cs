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
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textPrecio.Text) ||
                string.IsNullOrWhiteSpace(textGenero.Text) || string.IsNullOrWhiteSpace(textConsola.Text))
            {
                MessageBox.Show("Llene todos los campos necesarios.");
                return;
            }

            int precio;
            if (!int.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("Valor no válido en el campo Precio.");
                return;
            }

            Nodo nuevo = new Nodo();
            nuevo.Nombre = Convert.ToString(textNombre.Text);
            nuevo.Precio = precio;
            nuevo.Genero = Convert.ToString(textGenero.Text);
            nuevo.Consola = Convert.ToString(textConsola.Text);

            if (ExisteElemento(nuevo.Nombre))
            {
                MessageBox.Show("Ya existe un elemento igual.");
                return;
            }

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

        public bool ExisteElemento(string nombre)
        {
            Nodo actual = Primero;
            while (actual != null)
            {
                if (actual.Nombre == nombre)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
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
            string nodoBuscado = Convert.ToString(textNombreModificar.Text);

            if (string.IsNullOrWhiteSpace(nodoBuscado))
            {
                MessageBox.Show("Ingrese el nombre del elemento a modificar.");
                return;
            }

            Nodo actual = Primero;
            bool Encontrado = false;

            while (actual != null && !Encontrado)
            {
                if (actual.Nombre == nodoBuscado)
                {
                    Encontrado = true;
                    // Realizar la modificación
                    ModificarNodo(actual);
                }
                actual = actual.Siguiente;
            }

            if (!Encontrado)
            {
                MessageBox.Show("El elemento no existe.");
            }
        }

        public void ModificarNodo(Nodo nodo)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textPrecio.Text) ||
                string.IsNullOrWhiteSpace(textGenero.Text) || string.IsNullOrWhiteSpace(textConsola.Text))
            {
                MessageBox.Show("Ingrese todos los campos necesarios.");
                return;
            }

            int precio;
            if (!int.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("Valor no válido en el campo Precio.");
                return;
            }

            // Realizar la modificación del nodo
            nodo.Nombre = Convert.ToString(textNombre.Text);
            nodo.Precio = precio;
            nodo.Genero = Convert.ToString(textGenero.Text);
            nodo.Consola = Convert.ToString(textConsola.Text);
        }


        public void EliminarNodo()
        {
            string nodoBuscado = Convert.ToString(textNombreModificar.Text);

            if (string.IsNullOrWhiteSpace(nodoBuscado))
            {
                MessageBox.Show("Ingrese el nombre del elemento a eliminar.");
                return;
            }

            if (Primero == null)
            {
                MessageBox.Show("No hay elementos para eliminar.");
                return;
            }

            Nodo actual = Primero;
            Nodo anterior = null;
            bool Encontrado = false;

            while (actual != null && !Encontrado)
            {
                if (actual.Nombre == nodoBuscado)
                {
                    Encontrado = true;
                    // Realizar la eliminación
                    EliminarNodoEncontrado(actual, anterior);
                }
                else
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }
            }

            if (!Encontrado)
            {
                MessageBox.Show("El elemento no existe.");
            }
        }

        public void EliminarNodoEncontrado(Nodo nodo, Nodo anterior)
        {
            if (nodo == Primero)
            {
                Primero = Primero.Siguiente;
                if (Primero == null)
                {
                    Ultimo = null;
                }
            }
            else if (nodo == Ultimo)
            {
                anterior.Siguiente = null;
                Ultimo = anterior;
            }
            else
            {
                anterior.Siguiente = nodo.Siguiente;
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

        public void InsertarAlInicio()
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textPrecio.Text) ||
                string.IsNullOrWhiteSpace(textGenero.Text) || string.IsNullOrWhiteSpace(textConsola.Text))
            {
                MessageBox.Show("Llene todos los campos necesarios.");
                return;
            }

            int precio;
            if (!int.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("Valor no válido en el campo Precio.");
                return;
            }

            Nodo nuevo = new Nodo();
            nuevo.Nombre = Convert.ToString(textNombre.Text);
            nuevo.Precio = precio;
            nuevo.Genero = Convert.ToString(textGenero.Text);
            nuevo.Consola = Convert.ToString(textConsola.Text);

            if (ExisteElemento(nuevo.Nombre))
            {
                MessageBox.Show("Ya existe un elemento igual.");
                return;
            }

            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = Primero;
                Primero = nuevo;
            }
        }




        public void InsertarEnElMedio()
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textPrecio.Text) ||
                string.IsNullOrWhiteSpace(textGenero.Text) || string.IsNullOrWhiteSpace(textConsola.Text))
            {
                MessageBox.Show("Llene todos los campos necesarios.");
                return;
            }

            int precio;
            if (!int.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("Valor no válido en el campo Precio.");
                return;
            }

            Nodo nuevo = new Nodo();
            nuevo.Nombre = Convert.ToString(textNombre.Text);
            nuevo.Precio = precio;
            nuevo.Genero = Convert.ToString(textGenero.Text);
            nuevo.Consola = Convert.ToString(textConsola.Text);

            if (ExisteElemento(nuevo.Nombre))
            {
                MessageBox.Show("Ya existe un elemento igual.");
                return;
            }

            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                int longitud = ObtenerLongitud();
                int posicionMedia = longitud / 2;

                Nodo actual = Primero;
                Nodo anterior = null;
                int contador = 0;

                while (contador < posicionMedia)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                    contador++;
                }

                nuevo.Siguiente = actual;
                anterior.Siguiente = nuevo;
            }
        }

        private int ObtenerLongitud()
        {
            int longitud = 0;
            Nodo actual = Primero;

            while (actual != null)
            {
                longitud++;
                actual = actual.Siguiente;
            }

            return longitud;
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

        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            InsertarAlInicio();
            Mostrar();
        }

        private void btnInsertarMedio_Click(object sender, EventArgs e)
        {
            InsertarEnElMedio();
            Mostrar();
        }
    }
}
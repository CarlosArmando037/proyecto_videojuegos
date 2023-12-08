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
        private const int CapacidadMaxima = 10; // Tamaño máximo de la cola

        private string[] nombres = new string[CapacidadMaxima];
        private int[] precios = new int[CapacidadMaxima];
        private string[] generos = new string[CapacidadMaxima];
        private string[] consolas = new string[CapacidadMaxima];
        private int frente;
        private int fin;

        public EDcola()
        {
            frente = -1;
            fin = -1;
            InitializeComponent();
        }

        public void Insertar(string nombre, int precio, string genero, string consola)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(consola))
            {
                MessageBox.Show("Llena los campos faltantes.");
                return;
            }

            if (!int.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("El campo precio no es válido.");
                return;
            }

            if (EstaLlena())
            {
                MessageBox.Show("La cola está llena. No se puede encolar más elementos.");
                return;
            }

            if (EstaElementoExistente(nombre))
            {
                MessageBox.Show("Ya existe un elemento con el mismo nombre.");
                return;
            }

            if (EstaVacia())
            {
                frente = 0;
            }

            fin = (fin + 1) % CapacidadMaxima;

            nombres[fin] = nombre;
            precios[fin] = precio;
            generos[fin] = genero;
            consolas[fin] = consola;
        }

        private bool EstaElementoExistente(string nombre)
        {
            if (EstaVacia())
            {
                return false;
            }

            int indice = frente;
            do
            {
                if (nombres[indice] == nombre)
                {
                    return true;
                }

                indice = (indice + 1) % CapacidadMaxima;
            } while (indice != (fin + 1) % CapacidadMaxima);

            return false;
        }

        public void Desencolar()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La cola está vacía. No se puede desencolar.");
                return;
            }

            if (frente == fin)
            {
                // Si solo hay un elemento en la cola, reiniciar los índices
                frente = -1;
                fin = -1;
            }
            else
            {
                frente = (frente + 1) % CapacidadMaxima;
            }
        }

        public void Mostrar()
        {
            dataGridView1.Rows.Clear();

            if (EstaVacia())
            {
                MessageBox.Show("La cola está vacía.");
                return;
            }

            int indice = frente;
            do
            {
                dataGridView1.Rows.Add(nombres[indice], precios[indice], generos[indice], consolas[indice]);
                indice = (indice + 1) % CapacidadMaxima;
            } while (indice != (fin + 1) % CapacidadMaxima);
        }

        public void Modificar(string nombreBuscado, string nuevoNombre, int nuevoPrecio, string nuevoGenero, string nuevaConsola)
        {
            // Validar que se ingrese el nombre del elemento a modificar
            if (string.IsNullOrWhiteSpace(nombreBuscado))
            {
                MessageBox.Show("Ingrese el nombre del elemento a modificar.");
                return;
            }

            // Validar que la cola no esté vacía
            if (EstaVacia())
            {
                MessageBox.Show("La cola está vacía. No se puede modificar.");
                return;
            }

            int indice = frente;
            bool encontrado = false;

            do
            {
                if (nombres[indice] == nombreBuscado)
                {
                    encontrado = true;
                    break;
                }

                indice = (indice + 1) % CapacidadMaxima;
            } while (indice != (fin + 1) % CapacidadMaxima);

            // Validar que el elemento a modificar exista
            if (!encontrado)
            {
                MessageBox.Show("No existe el elemento.");
                return;
            }

            // Validar que los campos estén llenos
            if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoGenero) || string.IsNullOrWhiteSpace(nuevaConsola))
            {
                MessageBox.Show("Llene todos los campos.");
                return;
            }

            // Validar que el campo de precio contenga solo dígitos
            if (!int.TryParse(textPrecio.Text, out nuevoPrecio))
            {
                MessageBox.Show("El campo precio no es válido.");
                return;
            }

            nombres[indice] = nuevoNombre;
            precios[indice] = nuevoPrecio;
            generos[indice] = nuevoGenero;
            consolas[indice] = nuevaConsola;
        }

        public void Eliminar(string nombreBuscado)
        {
            MessageBox.Show("en mantenimiento");

            /*
            if (string.IsNullOrWhiteSpace(nombreBuscado))
            {
                MessageBox.Show("Ingrese el nombre del elemento a eliminar.");
                return;
            }

            if (EstaVacia())
            {
                MessageBox.Show("No hay elementos para eliminar.");
                return;
            }

            int indice = frente;
            int indiceAnterior = -1;
            bool encontrado = false;

            do
            {
                if (nombres[indice] == nombreBuscado)
                {
                    if (indice == frente)
                    {
                        frente = (frente + 1) % CapacidadMaxima;
                    }
                    else if (indice == fin)
                    {
                        fin = (fin - 1 + CapacidadMaxima) % CapacidadMaxima;
                    }
                    else
                    {
                        // Se elimina el elemento en el medio de la cola
                        for (int i = indice; i != fin; i = (i + 1) % CapacidadMaxima)
                        {
                            int siguiente = (i + 1) % CapacidadMaxima;
                            nombres[i] = nombres[siguiente];
                            precios[i] = precios[siguiente];
                            generos[i] = generos[siguiente];
                            consolas[i] = consolas[siguiente];
                        }

                        fin = (fin - 1 + CapacidadMaxima) % CapacidadMaxima;
                    }

                    encontrado = true;
                    break;
                }

                indiceAnterior = indice;
                indice = (indice + 1) % CapacidadMaxima;
            } while (indice != (fin + 1) % CapacidadMaxima);

            if (!encontrado)
            {
                MessageBox.Show("El elemento no existe.");
            }
            */
        }

        public void OrdenarAscendente()
        {
            if (EstaVacia() || frente == fin)
            {
                // No hay elementos o solo hay un elemento.
                return;
            }

            for (int i = frente; i != fin; i = (i + 1) % CapacidadMaxima)
            {
                for (int j = frente; j != (fin - 1 + CapacidadMaxima) % CapacidadMaxima; j = (j + 1) % CapacidadMaxima)
                {
                    int siguiente = (j + 1) % CapacidadMaxima;

                    if (string.Compare(nombres[j], nombres[siguiente]) > 0)
                    {
                        // Intercambiar elementos si están en el orden incorrecto
                        IntercambiarElementos(j, siguiente);
                    }
                }
            }
        }

        public void OrdenarDescendente()
        {
            if (EstaVacia() || frente == fin)
            {
                // No hay elementos o solo hay un elemento.
                return;
            }

            for (int i = frente; i != fin; i = (i + 1) % CapacidadMaxima)
            {
                for (int j = frente; j != (fin - 1 + CapacidadMaxima) % CapacidadMaxima; j = (j + 1) % CapacidadMaxima)
                {
                    int siguiente = (j + 1) % CapacidadMaxima;

                    if (string.Compare(nombres[j], nombres[siguiente]) < 0)
                    {
                        // Intercambiar elementos si están en el orden incorrecto
                        IntercambiarElementos(j, siguiente);
                    }
                }
            }
        }

        private void IntercambiarElementos(int indice1, int indice2)
        {
            // Intercambiar elementos en todas las matrices
            string tempNombre = nombres[indice1];
            int tempPrecio = precios[indice1];
            string tempGenero = generos[indice1];
            string tempConsola = consolas[indice1];

            nombres[indice1] = nombres[indice2];
            precios[indice1] = precios[indice2];
            generos[indice1] = generos[indice2];
            consolas[indice1] = consolas[indice2];

            nombres[indice2] = tempNombre;
            precios[indice2] = tempPrecio;
            generos[indice2] = tempGenero;
            consolas[indice2] = tempConsola;
        }

        private bool EstaVacia()
        {
            return frente == -1;
        }

        private bool EstaLlena()
        {
            return (frente == 0 && fin == CapacidadMaxima - 1) || (frente == fin + 1);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            int precio;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(textGenero.Text) || string.IsNullOrWhiteSpace(textConsola.Text))
            {
                MessageBox.Show("Llena todos los campos.");
                return;
            }

            if (!int.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("El campo precio no es válido.");
                return;
            }

            string genero = textGenero.Text;
            string consola = textConsola.Text;

            Insertar(nombre, precio, genero, consola);
            Mostrar();
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            Desencolar();
            Mostrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = textNombreModificar.Text;
            string nuevoNombre = textNombre.Text;
            int nuevoPrecio;

            // Inicializar nuevoPrecio antes de llamar a Modificar
            if (!int.TryParse(textPrecio.Text, out nuevoPrecio))
            {
                MessageBox.Show("El campo precio no es válido.");
                return;
            }

            try
            {
                Modificar(nombreBuscado, nuevoNombre, nuevoPrecio, textGenero.Text, textConsola.Text);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("en mantenimiento");
            /*
            string nombreBuscado = textNombreModificar.Text;

            try
            {
                if (EstaVacia())
                {
                    MessageBox.Show("No hay elementos para eliminar.");
                    return;
                }

                Eliminar(nombreBuscado);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
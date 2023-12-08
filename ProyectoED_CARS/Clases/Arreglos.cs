using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoED_CARS.Clases
{
    public class Arreglos
    {

        int longitud = 0;
        int cantidadReal = 0;
        VideoJuegoModels[] arreglo;

        // contructutor de con argumento opcional longitud
        /*
         public Arreglos(int longitud)
        {
            arreglo = new VideoJuegoModels[longitud];
        }
         */

        public Arreglos()
        {
            arreglo = new VideoJuegoModels[3];
        }


        //metodos
        public bool InsertarElementoArreglo(VideoJuegoModels videoJuego)
        {
            if (EstaLleno())
            {
                return false;
            }
            else
            {
                arreglo[cantidadReal] = videoJuego;

                cantidadReal++;
                return true;
            }
        }
        public void InsertarMedio(VideoJuegoModels videojuego)
        {
            int medio = 0;
            medio = arreglo.Length / 2;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i == medio)
                {
                    arreglo[i] = videojuego;
                }
            }
        }
        public bool EsVacio()
        {
            if (cantidadReal == 0)
            {
                return true;
            }
            return false;
        }
        public bool EstaLleno()
        {
            if (cantidadReal == arreglo.Length)
            {
                return true;
            }
            return false;
        }
        public int Longitud()
        {
            return arreglo.Length;
        }

        // para eliminar necesitas seleccionar a minimop uno, entonces tenddre que hcaer primero otro
        public void Eliminar( int objetivo)
        {
            //Console.WriteLine("inserte el elemento que quiere eliminar:");

            for (int i = 0; i <= cantidadReal; i++)
            {
                if (i == objetivo)
                {
                    arreglo[i] = null;
                    RecorrerArreglo();
                }
                cantidadReal--;
            }
        }
        public void RecorrerArreglo()
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[i] == null)
                    {
                        var temp = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = temp;
                    }
                }
            }
        }

        
        //como puedo hacer que me ordene con string?
        /*
        public void OrdenarAsc()
        {
            for (int i =0 ;i < arreglo.Length-1;i++)
            {
                for (int j = i+1; j<arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[i])
                    {

                    }
                }
            }
        }
        */


        public void ObtenerElemento(string objetivo)
        {
            if (EsVacio())
            {
                MessageBox.Show("la matriz esta vacia");
            }
            else
            {
                for (int i = 0; i < cantidadReal; i++)
                {
                    if (objetivo == arreglo[i].Titulo)
                    {
                        MessageBox.Show($"el juego es {arreglo[i].Titulo}, precio: {arreglo[i].Precio}, genero: {arreglo[i].Genero}, y plataforma: {arreglo[i].Plataforma}");
                        break;
                    }

                }
            }
        }
        /*
        public void ObtenerTodosElementos()
        {
            for (int j = 0; j < arreglo.Length; j++)
            {
                if (arreglo[j] != null)
                {
                    MessageBox.Show($"el juego se llama: {arreglo[j].Titulo}, cuesta: {arreglo[j].Precio}, de genero: {arreglo[j].Genero}, y plataforma: {arreglo[j].Plataforma}");
                }
            }
        }
        */
        public void Modificar(VideoJuegoModels videojuego, int objetivo)
        {
            if(objetivo < 0)
            {
                MessageBox.Show("no se aceptan numeros negativos");
            }
            for (int i = 0; i < cantidadReal; i++)
            {
                if (i == Convert.ToInt32(objetivo))
                {
                    arreglo[i] = videojuego;
                }
            }
        }
        public int CantidadReal()
        {
            return cantidadReal;
        }

    }
}

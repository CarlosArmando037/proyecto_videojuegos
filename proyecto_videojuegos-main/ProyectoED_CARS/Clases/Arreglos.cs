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
            arreglo = new VideoJuegoModels[10];
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
            if (longitud == 0)
            {
                return true;
            }
            return false;
        }
        public bool EstaLleno()
        {
            if (longitud == arreglo.Length)
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
        public void Eliminar(VideoJuegoModels videoJuego)
        {
            //Console.WriteLine("inserte el elemento que quiere eliminar:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (videoJuego.Titulo == arreglo[i].Titulo)
                {
                    arreglo[i] = null;
                    RecorrerArreglo();
                }
                cantidadReal++;
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
                        int temp = j;
                        i = j;
                        j = temp;
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


        public void ObtenerElemento(VideoJuegoModels videojuego)
        {
            if (EsVacio())
            {
                MessageBox.Show("la matriz esta vacia");
            }
            else
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i].Titulo == videojuego.Titulo)
                    {
                        MessageBox.Show($"el juego es {arreglo[i].Titulo}, precio: {arreglo[i].Precio}, genero: {arreglo[i].Genero}, y plataforma: {arreglo[i].Plataforma}");
                    }
                    else
                    {
                        MessageBox.Show("no se encontro elemento en la lista");
                    }

                }
            }
        }
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
        public void Modificar(VideoJuegoModels videojuego, int objetivo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i == objetivo)
                {
                    InsertarElementoArreglo(videojuego);

                }
                else
                {
                    MessageBox.Show("no se encontro ningun elemento");
                }
            }

        }


    }
}

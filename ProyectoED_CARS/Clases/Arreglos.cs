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
            arreglo = new VideoJuegoModels[100];
        }


        //metodos
        public void InsertarElementoArreglo(VideoJuegoModels videoJuego)
        {
            MessageBox.Show("en proceso");
            
        }

        public VideoJuegoModels[] mostrar()
        {
            return arreglo;
        }
        public void InsertarMedio(VideoJuegoModels videojuego)
        {
            int posicionMedia = cantidadReal / 2;

            for (int i = cantidadReal - 1; i > posicionMedia; i--)
            {
                arreglo[i] = arreglo[i - 1];
            }
            arreglo[posicionMedia] = videojuego;

            /*
            int medio = 0;
            medio = cantidadReal / 2;
            for (int i = 0; i < cantidadReal; i++)
            {
                if (i == medio)
                {
                    for (int iAux = i; iAux < cantidadReal; iAux++)
                    {
                        int minimo = iAux;

                        for (int j = iAux + 1; j < cantidadReal; j++)
                        {
                            VideoJuegoModels temporal = arreglo[iAux];
                            arreglo[iAux] = arreglo[j];
                            arreglo[j] = temporal;

                        }
                        //Console.Write(arreglo[i] + " ");

                    }

                    /*
                    VideoJuegoModels Juegos;
                    for (int j = i; j < cantidadReal;j++) 
                    {
                        Juegos = arreglo[j];
                        arreglo[j + 1] = Juegos;
                        arreglo[j] = null;
                    }
                    arreglo[i] = videojuego;
                    
                }
            }*/

        }
        public void InsertarFinal(VideoJuegoModels videoJuego)
        {
            if (EsVacio())
            {
                InsertarElementoArreglo(videoJuego);
            }
            else if(EstaLleno())
            {
                MessageBox.Show("el arreglo esta lleno");
            }
            else
            {
                arreglo[cantidadReal] = videoJuego;
                cantidadReal++;
            }
        }
        //validacioones de llenado y vacios
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
        public void Eliminar(string objetivo)
        {
            //Console.WriteLine("inserte el elemento que quiere eliminar:");

            for (int i = 0; i <= cantidadReal; i++)
            {
                if (arreglo[i].Titulo == objetivo)
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



        public void OrdenamientoASC()
        {
            for (int i = 0; i < cantidadReal; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < cantidadReal; j++)
                {
                    if (arreglo[j].Precio > arreglo[minimo].Precio)
                    {
                        VideoJuegoModels temporal = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = temporal;
                    }
                }
                //Console.Write(arreglo[i] + " ");

            }
        }
        public void OrdenamientoDES()
        {
            for (int i = 0; i < cantidadReal; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < cantidadReal; j++)
                {
                    if (arreglo[j].Precio < arreglo[minimo].Precio)
                    {
                        VideoJuegoModels temporal = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = temporal;

                    }

                }
                //Console.Write(arreglo[i] + " ");

            }
        }

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
        
        public void Modificar(VideoJuegoModels videojuego, string objetivo)
        {
            /*
            if(objetivo == )
            {
                MessageBox.Show("no se aceptan");
            }*/
            for (int i = 0; i < cantidadReal; i++)
            {
                if (arreglo[i].Titulo == objetivo)
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

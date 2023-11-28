using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoED_CARS.Clases
{
    public class Arreglos
    {
        //Arreglos[] arreglojuegos = new Arreglos[10];
        VideoJuegoModels MvideoJuego = new VideoJuegoModels();
        VideoJuegoModels[] matriz = new VideoJuegoModels[10]; 

        public bool Vacio()
        {
            if (matriz[0] == null)
            {
                return true;
            }
            return false;
        }
        public bool EstadoArreglo(int contador)
        {
            if (Vacio())
            {
                while (contador < matriz.Length)
                {
                    if (matriz[contador] == null)
                    {


                        return true;
                    }
                    contador++;
                }

            }
            else
            {
                MessageBox.Show("el arreglo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;

            /*
            int cont = 0;

            if (Vacio())
            {
                MessageBox.Show("el arreglo esta vacio","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                for(int i = 0; i < matriz.Length; i++)
                {
                    if (matriz[i] != null)
                    {
                        cont++;
                    }
                }
            }
            return cont;
            */
        }

        public void AñadirElementoArreglo(string nombre,string precio,string genero,string plataforma)
        {
            //VideoJuegoModels[] matriz = new VideoJuegoModels[10];
            
            if (Vacio())
            {
                MvideoJuego.Nombre = nombre;
                MvideoJuego.Precio = precio;
                MvideoJuego.Genero = genero;
                MvideoJuego.Plataforma = plataforma;
                matriz[0] = MvideoJuego;

            }
            else
            {
                
            }

            // = titulodeljuego;
        }
        
        /*
        public string MostrarArreglo(VideoJuegoModels[] matriz)
        {
            

            return nombre;
        }
        */
        

    }
}

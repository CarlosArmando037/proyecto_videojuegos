using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoED_CARS.Clases
{
    public class Pilas
    {
        int longitud = 0;
        int cantidadReal = 0;
        int cantidadReealAux = 0;
        VideoJuegoModels[] pilas;
        VideoJuegoModels[] pilaAux;

        // contructutor de con argumento opcional longitud
        //preguntar bien como funcionan las pilas y colas al profe supuestamente puede ser con arreglos;
        //pero no se si se utilizen metedos diferentes a los del arreglo en termino de 

        public Pilas()
        {
            pilas = new VideoJuegoModels[10];
            pilaAux = new VideoJuegoModels[15];
        }

        //metodos
        public void InsertarPila(VideoJuegoModels videoJuego)
        {
            if (EstaLleno())
            {
                MessageBox.Show("el arreglo de la pila principal esta llena");
            }
            else
            {
                pilas[cantidadReal] = videoJuego;
                cantidadReal++;
            }
        }
        //para insertar en el medio tienes que tener otra pila y moverlos de uno a otro
        /*
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
        */
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
            if (cantidadReal == pilas.Length)
            {
                return true;
            }
            return false;
        }
        public int Longitud()
        {
            return pilas.Length;
        }

        // para eliminar necesitas seleccionar a minimop uno, entonces tenddre que hcaer primero otro
        
        //para eliminar tienes que encontara un elemento especifico, entonces tienes que mover los elementos de una pila a otra, para encontaralo y eliminarlo;
        //luego volver a introducir los datos de la pila2 a la pila principal, y el vacio quedara a lo ultimo
        public void Eliminar(int objetivo)
        {
            //Console.WriteLine("inserte el elemento que quiere eliminar:");
            if (objetivo < 0)
            {
                MessageBox.Show("no se aceptan numeros negativos");
            }
            for (int i = cantidadReal-1; i > -1; i--)
            {
                if (i != objetivo)
                {
                    pilaAux[cantidadReealAux] = pilas[i];
                    cantidadReealAux++;
                    pilas[i] = null;
                    cantidadReal--;
                }
                else
                {
                    pilas[i] = null;
                    cantidadReal--;
                    break; 
                }
            }
            for (int i = cantidadReealAux-1; i > -1; i--)
            {

                pilas[cantidadReal] = pilaAux[i];
                pilaAux[i] = null;
                cantidadReealAux--;
            }
        }
        public void RecorrerArreglo()
        {
            for (int i = 0; i < pilas.Length - 1; i++)
            {
                for (int j = i + 1; j < pilas.Length; j++)
                {
                    if (pilas[i] == null)
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

        public VideoJuegoModels[] mostrar()
        {
            return pilas;
        }
        //obetner elemento esta mal, porque este rrecorre la matriz, lo que se espera es que los añada a otra matriz
        public void ObtenerElemento(VideoJuegoModels videojuego)
        {
            if (EsVacio())
            {
                Console.WriteLine("la matriz esta vacia");
            }
            else
            {
                int count = 0;
                for (int i = cantidadReal; i > 0; i--)
                {
                    //este if hahce que agarrelos datos y los envie a  la pila auxiliar 
                    if(pilas[cantidadReal] != null)
                    {

                        pilaAux[count] = pilas[cantidadReal];
                        count++;
                    }
                    // este optro if es el que compara lo que se busca con los datos dentro de la pila
                    if (pilas[i].Titulo == videojuego.Titulo)
                    {
                        MessageBox.Show($"se encontro el elemento en la posicion {i}");
                        //Console.WriteLine($"el juego es {pilas[i].Titulo}, precio: {pilas[i].Precio}, genero: {pilas[i].Genero}, y plataforma: {pilas[i].Plataforma}");
                    }
                    MessageBox.Show("no se encontro ningun elemento que coinsida");    
                }
            }
        }
        public void ObtenerTodosElementos()
        {
            for (int j = 0; j < pilas.Length; j++)
            {
                if (pilas[j] != null)
                {
                    MessageBox.Show($"el juego se llama: {pilas[j].Titulo}, cuesta: {pilas[j].Precio}, de genero: {pilas[j].Genero}, y plataforma: {pilas[j].Plataforma}");
                }
            }

        }

        public void Modificar(VideoJuegoModels videojuego, int objetivo)
        {
            if (objetivo < 0)
            {
                MessageBox.Show("no se aceptan numeros negativos");
            }
            for (int i = cantidadReal; i > 0; i--)
            {
                if (i != objetivo)
                {
                    pilaAux[cantidadReealAux] = pilas[i];
                    cantidadReealAux++;
                    pilas[i] = null;
                    cantidadReal--;
                }
                else
                {
                    pilas[i] = videojuego;
                }
            }
            for (int i = cantidadReealAux; i > 0 ; i--)
            {
                pilas[cantidadReal] = pilaAux[i];
                cantidadReal++;
                pilaAux[i] = null;
                cantidadReealAux--;
            }
        }
        

    }
}

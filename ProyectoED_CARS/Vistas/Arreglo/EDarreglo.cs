using ProyectoED_CARS.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoED_CARS
{
    public partial class EDarreglo : Form
    {
        VideoJuegoModels videoJuego = new VideoJuegoModels();
        Arreglos arreglos = new Arreglos();
        int contador = 0;

        public EDarreglo(VideoJuegoModels videojuego = null)
        {
            InitializeComponent();


        }

        private void EDarreglo_Load(object sender, EventArgs e)
        {

        }
        private void btn_actualizar(object sender, EventArgs e)
        {

        }

        //VideoJuegoModels[] matriz;
        private void btn_añadir(object sender, EventArgs e)
        {
            
            if (txtB_titulo.Text == string.Empty || txtB_precio.Text == string.Empty || txtB_genero.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("inserte todos los datos");
            }
            else
            {
                try
                {
                    int dato = Convert.ToInt32(txtB_precio.Text);

                    VideoJuegoModels videoJuego = new VideoJuegoModels();

                    videoJuego.Titulo = txtB_titulo.Text;
                    videoJuego.Precio = Convert.ToInt32(txtB_precio.Text);
                    videoJuego.Genero = txtB_genero.Text;
                    if (comboBox1.SelectedItem == null)
                    {
                        videoJuego.Plataforma = comboBox1.Text.ToString();
                    }
                    else
                    {
                        videoJuego.Plataforma = comboBox1.SelectedItem.ToString();
                    }

                    arreglos.InsertarElementoArreglo(videoJuego);

                    contador++;
                    mostrar();
                }
                catch
                {
                    MessageBox.Show("el dato de presio es en entero");
                }  
            }

            comboBox1.Text = null;
            txtB_titulo.Clear();
            txtB_precio.Clear();
            txtB_genero.Clear();

        }

        public void mostrar()
        {
            VideoJuegoModels[] array = arreglos.mostrar();

            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "nombre";
            dataGridView1.Columns[1].Name = "precio";
            dataGridView1.Columns[2].Name = "genero";
            dataGridView1.Columns[3].Name = "plataforma";

            //VideoJuegoModels[] videoJuego;
            for (int i=0; i!=array.Length;i++)
            {
                if (array[i] == null)
                    break;
                else 
                    dataGridView1.Rows.Add(array[i].Titulo, array[i].Precio, array[i].Genero, array[i].Plataforma);

                /*
                if (i < contador)
                {
                    dataGridView1.Rows.Add(array[i].Titulo, array[i].Precio, array[i].Genero, array[i].Plataforma);
                    i++;
                }
                else if (i>contador)
                {
                    dataGridView1.Rows.Add(array[i].Titulo, array[i].Precio, array[i].Genero, array[i].Plataforma);
                    i--;
                }*/
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar(object sender, EventArgs e)
        {
            VideoJuegoModels videoJuego = new VideoJuegoModels();

            //falta saber como obtener el id de la celda del datagridview
            string objetivo = txtB_Buscar.Text;
            
            videoJuego.Titulo = txtB_titulo.Text;
            videoJuego.Precio = Convert.ToInt32(txtB_precio.Text);
            videoJuego.Genero = txtB_genero.Text;
            if (comboBox1.SelectedItem == null)
            {
                videoJuego.Plataforma = comboBox1.Text.ToString();
            }
            else
            {
                videoJuego.Plataforma = comboBox1.SelectedItem.ToString();
            }

            arreglos.Modificar(videoJuego, objetivo);
            mostrar();
            comboBox1.Text = null;
            txtB_titulo.Clear();
            txtB_precio.Clear();
            txtB_genero.Clear();
            //ActualizarDataGridView(videoJuego);
        }

        private void btnEliminar(object sender, EventArgs e)
        {
            string objetivo = txtB_Buscar.Text;
            arreglos.Eliminar(objetivo);
            contador--;

            mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string objetivo = txtB_Buscar.Text;
            arreglos.ObtenerElemento(objetivo);
        }

        private void btn_InsMedio_Click(object sender, EventArgs e)
        {

            if (txtB_titulo.Text == string.Empty || txtB_precio.Text == string.Empty || txtB_genero.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("inserte todos los datos");
            }
            else
            {
                try
                {
                    int dato = Convert.ToInt32(txtB_precio.Text);

                    VideoJuegoModels videoJuego = new VideoJuegoModels();

                    videoJuego.Titulo = txtB_titulo.Text;
                    videoJuego.Precio = Convert.ToInt32(txtB_precio.Text);
                    videoJuego.Genero = txtB_genero.Text;
                    if (comboBox1.SelectedItem == null)
                    {
                        videoJuego.Plataforma = comboBox1.Text.ToString();
                    }
                    else
                    {
                        videoJuego.Plataforma = comboBox1.SelectedItem.ToString();
                    }

                    arreglos.InsertarMedio(videoJuego);

                    contador++;
                    mostrar();
                }
                catch
                {
                    MessageBox.Show("el dato de presio es en entero");
                }
            }
        }

        private void btn_ordenarASC_Click(object sender, EventArgs e)
        {
            arreglos.OrdenamientoASC();
            mostrar();
        }

        private void btn_OrdenarDes_Click(object sender, EventArgs e)
        {
            arreglos.OrdenamientoDES();
            mostrar();
        }

        private void btn_InsFinal_Click(object sender, EventArgs e)
        {
            if (txtB_titulo.Text == string.Empty || txtB_precio.Text == string.Empty || txtB_genero.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("inserte todos los datos");
            }
            else
            {
                try
                {
                    int dato = Convert.ToInt32(txtB_precio.Text);

                    VideoJuegoModels videoJuego = new VideoJuegoModels();

                    videoJuego.Titulo = txtB_titulo.Text;
                    videoJuego.Precio = Convert.ToInt32(txtB_precio.Text);
                    videoJuego.Genero = txtB_genero.Text;
                    if (comboBox1.SelectedItem == null)
                    {
                        videoJuego.Plataforma = comboBox1.Text.ToString();
                    }
                    else
                    {
                        videoJuego.Plataforma = comboBox1.SelectedItem.ToString();
                    }

                    arreglos.InsertarFinal(videoJuego);

                    contador++;
                    mostrar();
                }
                catch
                {
                    MessageBox.Show("el dato de presio es en entero");
                }
                comboBox1.Text = null;
                txtB_titulo.Clear();
                txtB_precio.Clear();
                txtB_genero.Clear();
            }
        }
    }
}

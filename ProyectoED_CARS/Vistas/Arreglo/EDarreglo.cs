using ProyectoED_CARS.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            if(videoJuego.Titulo == "" || videoJuego.Precio == "" || videoJuego.Genero == "" || videoJuego.Plataforma == "")
            {
                MessageBox.Show("inserte los datos");
            }
            else
            {
                VideoJuegoModels videoJuego = new VideoJuegoModels();

                videoJuego.Titulo = txtB_titulo.Text;
                videoJuego.Precio = txtB_precio.Text;
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
                ActualizarDataGridView(videoJuego);
                contador++;
            }
            //txtB_titulo.Text = null;
            //txtB_precio.Text = null;
            //txtB_genero.Text = null;
            comboBox1.Text = null;
            txtB_titulo.Clear();
            txtB_precio.Clear();
            txtB_genero.Clear();

        }

        VideoJuegoModels[] matriz = new VideoJuegoModels[20];
        private void ActualizarDataGridView(VideoJuegoModels videoJuego)
        {

            dataGridView1.Rows.Clear();

            matriz[contador] = videoJuego;
            for (int i = 0; i <= contador; i++)
            {
                
                int fila = dataGridView1.Rows.Add();

                dataGridView1.Rows[fila].Cells["CId"].Value = i;
                dataGridView1.Rows[fila].Cells["Ctitulo"].Value = matriz[i].Titulo;
                dataGridView1.Rows[fila].Cells["CPrecio"].Value = matriz[i].Precio;
                dataGridView1.Rows[fila].Cells["CGenero"].Value = matriz[i].Genero;
                dataGridView1.Rows[fila].Cells["CPlataformas"].Value = matriz[i].Plataforma;
                
            }
        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar(object sender, EventArgs e)
        {
            VideoJuegoModels videoJuego = new VideoJuegoModels();

            //falta saber como obtener el id de la celda del datagridview
            int objetivo = Convert.ToInt32(txtB_Buscar.Text);
            
            videoJuego.Titulo = txtB_titulo.Text;
            videoJuego.Precio = txtB_precio.Text;
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
            ActualizarDataGridView(videoJuego);
        }

        private void btnEliminar(object sender, EventArgs e)
        {
            int objetivo = Convert.ToInt32(txtB_Buscar.Text);
            arreglos.Eliminar(objetivo);
            contador--;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string objetivo = txtB_Buscar.Text;
            arreglos.ObtenerElemento(objetivo);
        }
    }
}

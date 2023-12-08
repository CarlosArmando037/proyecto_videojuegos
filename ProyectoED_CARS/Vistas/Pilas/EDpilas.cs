using ProyectoED_CARS.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoED_CARS
{
    public partial class EDpilas : Form
    {
        VideoJuegoModels videoJuego = new VideoJuegoModels();
        Pilas pilas = new Pilas();
        int contador = 0;
        public EDpilas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (videoJuego.Titulo == "" || videoJuego.Precio == "" || videoJuego.Genero == "" || videoJuego.Plataforma == "")
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

                pilas.InsertarPila(videoJuego);
                //ActualizarDataGridView(videoJuego);
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            /*
            int fila = dataGridView1.Rows.Add();
            
            dataGridView1.Rows[fila].Cells["CId"].Value = contador;
            dataGridView1.Rows[fila].Cells["Ctitulo"].Value = videoJuego.Titulo;
            dataGridView1.Rows[fila].Cells["CPrecio"].Value = videoJuego.Precio;
            dataGridView1.Rows[fila].Cells["CGenero"].Value = videoJuego.Genero;
            dataGridView1.Rows[fila].Cells["CPlataformas"].Value = videoJuego.Plataforma;
            */
        }
        private void ActualizarDataGridView(VideoJuegoModels videoJuego)
        {

            dataGridView1.Rows.Clear();
            VideoJuegoModels[] matriz = new VideoJuegoModels[20];
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
        private void btn_edit_Click(object sender, EventArgs e)
        {
            VideoJuegoModels videoJuego = new VideoJuegoModels();

            //falta saber como obtener el id de la celda del datagridview
            int objetivo = Convert.ToInt32(txtB_buscar.Text);

            //prueba para insertar en el repositorio numero 2

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

            pilas.Modificar(videoJuego,objetivo);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int objetivo = Convert.ToInt32(txtB_buscar.Text);
            pilas.Eliminar(objetivo);
        }
    }
}

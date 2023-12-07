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
        private void btn_añadir(object sender, EventArgs e)
        {

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


            }
            else
            {
                arreglos.InsertarElementoArreglo(videoJuego);
                contador++;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar(object sender, EventArgs e)
        {
            //falta saber como obtener el id de la celda del datagridview
            int objetivo =2;

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

        }

        private void btnEliminar(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string objetivo = txtB_Buscar.Text;
            arreglos.ObtenerElemento(objetivo);
        }
    }
}

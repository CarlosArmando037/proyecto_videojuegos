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
            if (videoJuego.Titulo == "" || videoJuego.Precio == "" || videoJuego.Genero == "" || videoJuego.Plataforma == "")
            {
                MessageBox.Show("inserte los datos");
            }
            else
            {
                pilas.InsertarPila(videoJuego);
                contador++;
            }

            txtB_titulo.Text = null;
            txtB_precio.Text = null;
            txtB_genero.Text = null;
            comboBox1.Text = null;

            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int fila = dataGridView1.Rows.Add();

            dataGridView1.Rows[fila].Cells["CId"].Value = contador;
            dataGridView1.Rows[fila].Cells["Ctitulo"].Value = videoJuego.Titulo;
            dataGridView1.Rows[fila].Cells["CPrecio"].Value = videoJuego.Precio;
            dataGridView1.Rows[fila].Cells["CGenero"].Value = videoJuego.Genero;
            dataGridView1.Rows[fila].Cells["CPlataformas"].Value = videoJuego.Plataforma;
        }
    }
}

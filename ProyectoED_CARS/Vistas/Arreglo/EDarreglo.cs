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
        //Arreglos aRreglos = new Arreglos();
        VideoJuegoModels VJmodel = new VideoJuegoModels();
        VideoJuegoModels[] matriz;


        int contador=0;
        //Arreglos arreglos=null
        public EDarreglo(VideoJuegoModels videojuego = null)
        {
            InitializeComponent();

            if (videojuego != null)
            {
                MessageBox.Show($"los datos llegaron son: {videojuego.Nombre} Y {videojuego.Precio} ");


            }

        }

        private void EDarreglo_Load(object sender, EventArgs e)
        {

        }
        private void btn_actualizar(object sender, EventArgs e)
        {

            /*--------respuesta dada del profe
            int fila = dataGridView1.Rows.Add();

            dataGridView1.Rows[fila].Cells["Ctitulo"].Value = matriz[0].Nombre;
            dataGridView1.Rows[fila].Cells["CPPrecio"].Value = matriz[0].Precio;
            dataGridView1.Rows[fila].Cells["CGenero"].Value = matriz[0].Genero;
            dataGridView1.Rows[fila].Cells["CPlataformas"].Value = matriz[0].Plataforma;
            */
            int fila = dataGridView1.Rows.Add();

            dataGridView1.Rows[fila].Cells["Ctitulo"].Value = matriz[0].Nombre;

        }
        Arreglos arreglos= new Arreglos();
        private void btn_añadir(object sender, EventArgs e)
        {
            if (arreglos.EstadoArreglo(contador)==true)
            {
                añadir_arreglo añadir_Arreglo = new añadir_arreglo();
                añadir_Arreglo.Show();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar(object sender, EventArgs e)
        {

        }
    }
}

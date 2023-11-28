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
    public partial class Menu : Form
    {
        añadir_arreglo añadir = new añadir_arreglo();
        public Menu()
        {
            InitializeComponent();
        }


        private void btnArray_Click(object sender, EventArgs e)
        {
            
            EDarreglo arreglos = new EDarreglo();
            arreglos.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            EDlista listas = new EDlista();
            listas.Show();
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            EDpilas pilas = new EDpilas();
            pilas.Show();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            EDcola cola = new EDcola();
            cola.Show();
        }
    }
}

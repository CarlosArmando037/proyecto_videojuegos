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
    public partial class añadir_arreglo : Form
    {
        Arreglos arreglos = new Arreglos();
        EDarreglo algo;
        VideoJuegoModels[] matriz;
        
        int contador=0;

        public añadir_arreglo()
        {
            InitializeComponent();
            
        }

        private void Añadir_Click(object sender, EventArgs e)
        {

            matriz[contador].Nombre = textBox1.Text;
            matriz[contador].Precio = textBox2.Text;
            matriz[contador].Genero = textBox3.Text;
            matriz[contador].Plataforma = comboBox1.SelectedItem.ToString();

            //mostrar.ShowDialog();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            arreglos.AñadirElementoArreglo(matriz[contador].Nombre, matriz[contador].Precio, matriz[contador].Genero, matriz[contador].Plataforma, contador);
            contador++;

            //nuevamatriz = arreglos.AñadirElementoArreglo(entry1, entry2, entry3, entry4);
            MessageBox.Show("se ha creado exitosamente el registro", "Agregado", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            Close();
            EDarreglo eDarreglo = new EDarreglo(matriz[contador]);
            eDarreglo.ShowDialog();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            
            Close();
        }

    }
}

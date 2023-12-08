namespace ProyectoED_CARS
{
    partial class EDarreglo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ctitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPlataformas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.txtB_Buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_titulo = new System.Windows.Forms.TextBox();
            this.txtB_precio = new System.Windows.Forms.TextBox();
            this.txtB_genero = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_InsMedio = new System.Windows.Forms.Button();
            this.btn_InsFinal = new System.Windows.Forms.Button();
            this.btn_ordenarASC = new System.Windows.Forms.Button();
            this.btn_OrdenarDes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arreglos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insertar Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_añadir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoED_CARS.Properties.Resources.Pixel_Art_Seamless_Background;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnEditar);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ctitulo,
            this.CPrecio,
            this.CGenero,
            this.CPlataformas});
            this.dataGridView1.Location = new System.Drawing.Point(25, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(532, 225);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Ctitulo
            // 
            this.Ctitulo.HeaderText = "Ctitulo";
            this.Ctitulo.Name = "Ctitulo";
            this.Ctitulo.ReadOnly = true;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "CPrecio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            // 
            // CGenero
            // 
            this.CGenero.HeaderText = "CGenero";
            this.CGenero.Name = "CGenero";
            this.CGenero.ReadOnly = true;
            // 
            // CPlataformas
            // 
            this.CPlataformas.HeaderText = "CPlataformas";
            this.CPlataformas.Name = "CPlataformas";
            this.CPlataformas.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnEliminar);
            // 
            // txtB_Buscar
            // 
            this.txtB_Buscar.Location = new System.Drawing.Point(624, 73);
            this.txtB_Buscar.Name = "txtB_Buscar";
            this.txtB_Buscar.Size = new System.Drawing.Size(100, 20);
            this.txtB_Buscar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "buscar elemento";
            // 
            // txtB_titulo
            // 
            this.txtB_titulo.Location = new System.Drawing.Point(624, 201);
            this.txtB_titulo.Name = "txtB_titulo";
            this.txtB_titulo.Size = new System.Drawing.Size(100, 20);
            this.txtB_titulo.TabIndex = 9;
            // 
            // txtB_precio
            // 
            this.txtB_precio.Location = new System.Drawing.Point(624, 258);
            this.txtB_precio.Name = "txtB_precio";
            this.txtB_precio.Size = new System.Drawing.Size(100, 20);
            this.txtB_precio.TabIndex = 10;
            // 
            // txtB_genero
            // 
            this.txtB_genero.Location = new System.Drawing.Point(624, 318);
            this.txtB_genero.Name = "txtB_genero";
            this.txtB_genero.Size = new System.Drawing.Size(100, 20);
            this.txtB_genero.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PC",
            "Xbox",
            "Play",
            "Switch"});
            this.comboBox1.Location = new System.Drawing.Point(624, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "presio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "plataforma";
            // 
            // btn_InsMedio
            // 
            this.btn_InsMedio.Location = new System.Drawing.Point(253, 99);
            this.btn_InsMedio.Name = "btn_InsMedio";
            this.btn_InsMedio.Size = new System.Drawing.Size(75, 39);
            this.btn_InsMedio.TabIndex = 17;
            this.btn_InsMedio.Text = "Insertar Medio";
            this.btn_InsMedio.UseVisualStyleBackColor = true;
            this.btn_InsMedio.Click += new System.EventHandler(this.btn_InsMedio_Click);
            // 
            // btn_InsFinal
            // 
            this.btn_InsFinal.Location = new System.Drawing.Point(253, 152);
            this.btn_InsFinal.Name = "btn_InsFinal";
            this.btn_InsFinal.Size = new System.Drawing.Size(75, 36);
            this.btn_InsFinal.TabIndex = 18;
            this.btn_InsFinal.Text = "Insertar Final";
            this.btn_InsFinal.UseVisualStyleBackColor = true;
            this.btn_InsFinal.Click += new System.EventHandler(this.btn_InsFinal_Click);
            // 
            // btn_ordenarASC
            // 
            this.btn_ordenarASC.Location = new System.Drawing.Point(41, 61);
            this.btn_ordenarASC.Name = "btn_ordenarASC";
            this.btn_ordenarASC.Size = new System.Drawing.Size(75, 43);
            this.btn_ordenarASC.TabIndex = 19;
            this.btn_ordenarASC.Text = "Ordenar Ascendente";
            this.btn_ordenarASC.UseVisualStyleBackColor = true;
            this.btn_ordenarASC.Click += new System.EventHandler(this.btn_ordenarASC_Click);
            // 
            // btn_OrdenarDes
            // 
            this.btn_OrdenarDes.Location = new System.Drawing.Point(41, 125);
            this.btn_OrdenarDes.Name = "btn_OrdenarDes";
            this.btn_OrdenarDes.Size = new System.Drawing.Size(75, 43);
            this.btn_OrdenarDes.TabIndex = 20;
            this.btn_OrdenarDes.Text = "Ordenar Desendente";
            this.btn_OrdenarDes.UseVisualStyleBackColor = true;
            this.btn_OrdenarDes.Click += new System.EventHandler(this.btn_OrdenarDes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EDarreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_OrdenarDes);
            this.Controls.Add(this.btn_ordenarASC);
            this.Controls.Add(this.btn_InsFinal);
            this.Controls.Add(this.btn_InsMedio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtB_genero);
            this.Controls.Add(this.txtB_precio);
            this.Controls.Add(this.txtB_titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_Buscar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EDarreglo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EDarreglo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtB_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_titulo;
        private System.Windows.Forms.TextBox txtB_precio;
        private System.Windows.Forms.TextBox txtB_genero;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_InsMedio;
        private System.Windows.Forms.Button btn_InsFinal;
        private System.Windows.Forms.Button btn_ordenarASC;
        private System.Windows.Forms.Button btn_OrdenarDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlataformas;
        private System.Windows.Forms.Button button2;
    }
}
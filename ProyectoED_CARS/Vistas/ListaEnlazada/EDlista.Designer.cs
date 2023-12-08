namespace ProyectoED_CARS
{
    partial class EDlista
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAcendente = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombreJuego = new System.Windows.Forms.Label();
            this.lblPrecioJuego = new System.Windows.Forms.Label();
            this.lblGeneroJuego = new System.Windows.Forms.Label();
            this.lblConsolaJuego = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textConsola = new System.Windows.Forms.TextBox();
            this.lblNombreAModificar = new System.Windows.Forms.Label();
            this.textNombreModificar = new System.Windows.Forms.TextBox();
            this.btnInsertarInicio = new System.Windows.Forms.Button();
            this.btnInsertarMedio = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.btnInsertar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(47, 100);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(196, 46);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar Final";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.btnModificar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(308, 100);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 46);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.btnEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(525, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAcendente
            // 
            this.btnAcendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.btnAcendente.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcendente.ForeColor = System.Drawing.Color.White;
            this.btnAcendente.Location = new System.Drawing.Point(747, 100);
            this.btnAcendente.Name = "btnAcendente";
            this.btnAcendente.Size = new System.Drawing.Size(159, 46);
            this.btnAcendente.TabIndex = 4;
            this.btnAcendente.Text = "Acendente";
            this.btnAcendente.UseVisualStyleBackColor = false;
            this.btnAcendente.Click += new System.EventHandler(this.btnAcendente_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.btnDescendente.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescendente.ForeColor = System.Drawing.Color.White;
            this.btnDescendente.Location = new System.Drawing.Point(979, 100);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(172, 46);
            this.btnDescendente.TabIndex = 5;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = false;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Genero,
            this.Consola});
            this.dataGridView1.Location = new System.Drawing.Point(256, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(677, 272);
            this.dataGridView1.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 8;
            this.Genero.Name = "Genero";
            this.Genero.Width = 150;
            // 
            // Consola
            // 
            this.Consola.HeaderText = "Consola";
            this.Consola.MinimumWidth = 8;
            this.Consola.Name = "Consola";
            this.Consola.Width = 150;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.btnCerrar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1029, 636);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 46);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombreJuego
            // 
            this.lblNombreJuego.AutoSize = true;
            this.lblNombreJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(107)))), ((int)(((byte)(140)))));
            this.lblNombreJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreJuego.ForeColor = System.Drawing.Color.White;
            this.lblNombreJuego.Location = new System.Drawing.Point(42, 464);
            this.lblNombreJuego.Name = "lblNombreJuego";
            this.lblNombreJuego.Size = new System.Drawing.Size(107, 29);
            this.lblNombreJuego.TabIndex = 12;
            this.lblNombreJuego.Text = "Nombre";
            // 
            // lblPrecioJuego
            // 
            this.lblPrecioJuego.AutoSize = true;
            this.lblPrecioJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(107)))), ((int)(((byte)(140)))));
            this.lblPrecioJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioJuego.ForeColor = System.Drawing.Color.White;
            this.lblPrecioJuego.Location = new System.Drawing.Point(42, 522);
            this.lblPrecioJuego.Name = "lblPrecioJuego";
            this.lblPrecioJuego.Size = new System.Drawing.Size(89, 29);
            this.lblPrecioJuego.TabIndex = 13;
            this.lblPrecioJuego.Text = "Precio";
            // 
            // lblGeneroJuego
            // 
            this.lblGeneroJuego.AutoSize = true;
            this.lblGeneroJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(107)))), ((int)(((byte)(140)))));
            this.lblGeneroJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroJuego.ForeColor = System.Drawing.Color.White;
            this.lblGeneroJuego.Location = new System.Drawing.Point(42, 575);
            this.lblGeneroJuego.Name = "lblGeneroJuego";
            this.lblGeneroJuego.Size = new System.Drawing.Size(100, 29);
            this.lblGeneroJuego.TabIndex = 14;
            this.lblGeneroJuego.Text = "Genero";
            // 
            // lblConsolaJuego
            // 
            this.lblConsolaJuego.AutoSize = true;
            this.lblConsolaJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(67)))), ((int)(((byte)(91)))));
            this.lblConsolaJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsolaJuego.ForeColor = System.Drawing.Color.White;
            this.lblConsolaJuego.Location = new System.Drawing.Point(42, 636);
            this.lblConsolaJuego.Name = "lblConsolaJuego";
            this.lblConsolaJuego.Size = new System.Drawing.Size(109, 29);
            this.lblConsolaJuego.TabIndex = 15;
            this.lblConsolaJuego.Text = "Consola";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(160, 464);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(139, 26);
            this.textNombre.TabIndex = 16;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(160, 522);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(139, 26);
            this.textPrecio.TabIndex = 17;
            this.textPrecio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(160, 578);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(139, 26);
            this.textGenero.TabIndex = 18;
            // 
            // textConsola
            // 
            this.textConsola.Location = new System.Drawing.Point(160, 635);
            this.textConsola.Name = "textConsola";
            this.textConsola.Size = new System.Drawing.Size(139, 26);
            this.textConsola.TabIndex = 19;
            // 
            // lblNombreAModificar
            // 
            this.lblNombreAModificar.AutoSize = true;
            this.lblNombreAModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.lblNombreAModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAModificar.ForeColor = System.Drawing.Color.White;
            this.lblNombreAModificar.Location = new System.Drawing.Point(468, 454);
            this.lblNombreAModificar.Name = "lblNombreAModificar";
            this.lblNombreAModificar.Size = new System.Drawing.Size(297, 25);
            this.lblNombreAModificar.TabIndex = 20;
            this.lblNombreAModificar.Text = "Nombre a modificar o eliminar";
            // 
            // textNombreModificar
            // 
            this.textNombreModificar.Location = new System.Drawing.Point(525, 491);
            this.textNombreModificar.Name = "textNombreModificar";
            this.textNombreModificar.Size = new System.Drawing.Size(193, 26);
            this.textNombreModificar.TabIndex = 21;
            this.textNombreModificar.TextChanged += new System.EventHandler(this.textNombreModificar_TextChanged);
            // 
            // btnInsertarInicio
            // 
            this.btnInsertarInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.btnInsertarInicio.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarInicio.ForeColor = System.Drawing.Color.White;
            this.btnInsertarInicio.Location = new System.Drawing.Point(992, 203);
            this.btnInsertarInicio.Name = "btnInsertarInicio";
            this.btnInsertarInicio.Size = new System.Drawing.Size(159, 88);
            this.btnInsertarInicio.TabIndex = 22;
            this.btnInsertarInicio.Text = "Insertar Inicio";
            this.btnInsertarInicio.UseVisualStyleBackColor = false;
            this.btnInsertarInicio.Click += new System.EventHandler(this.btnInsertarInicio_Click);
            // 
            // btnInsertarMedio
            // 
            this.btnInsertarMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.btnInsertarMedio.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarMedio.ForeColor = System.Drawing.Color.White;
            this.btnInsertarMedio.Location = new System.Drawing.Point(47, 203);
            this.btnInsertarMedio.Name = "btnInsertarMedio";
            this.btnInsertarMedio.Size = new System.Drawing.Size(159, 88);
            this.btnInsertarMedio.TabIndex = 23;
            this.btnInsertarMedio.Text = "Insertar Medio";
            this.btnInsertarMedio.UseVisualStyleBackColor = false;
            this.btnInsertarMedio.Click += new System.EventHandler(this.btnInsertarMedio_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoED_CARS.Properties.Resources.lista__;
            this.pictureBox2.Location = new System.Drawing.Point(396, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoED_CARS.Properties.Resources.Preview_and_Download_Wallpaper___HD_Wallpapers___Desktop_Background_Images;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1196, 715);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EDlista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1191, 706);
            this.Controls.Add(this.btnInsertarMedio);
            this.Controls.Add(this.btnInsertarInicio);
            this.Controls.Add(this.textNombreModificar);
            this.Controls.Add(this.lblNombreAModificar);
            this.Controls.Add(this.textConsola);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblConsolaJuego);
            this.Controls.Add(this.lblGeneroJuego);
            this.Controls.Add(this.lblPrecioJuego);
            this.Controls.Add(this.lblNombreJuego);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDescendente);
            this.Controls.Add(this.btnAcendente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EDlista";
            this.Text = "EDlista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAcendente;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consola;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNombreJuego;
        private System.Windows.Forms.Label lblPrecioJuego;
        private System.Windows.Forms.Label lblGeneroJuego;
        private System.Windows.Forms.Label lblConsolaJuego;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textConsola;
        private System.Windows.Forms.Label lblNombreAModificar;
        private System.Windows.Forms.TextBox textNombreModificar;
        private System.Windows.Forms.Button btnInsertarInicio;
        private System.Windows.Forms.Button btnInsertarMedio;
    }
}
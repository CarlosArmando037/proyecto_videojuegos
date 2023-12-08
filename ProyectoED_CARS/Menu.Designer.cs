namespace ProyectoED_CARS
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnColas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(695, 90);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(344, 32);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Proyecto Videojuegos ";
            // 
            // btnArray
            // 
            this.btnArray.BackColor = System.Drawing.Color.Navy;
            this.btnArray.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnArray.FlatAppearance.BorderSize = 0;
            this.btnArray.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnArray.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArray.ForeColor = System.Drawing.Color.White;
            this.btnArray.Location = new System.Drawing.Point(658, 356);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(107, 47);
            this.btnArray.TabIndex = 2;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = false;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLista.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLista.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.White;
            this.btnLista.Location = new System.Drawing.Point(809, 238);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(107, 47);
            this.btnLista.TabIndex = 3;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnPilas
            // 
            this.btnPilas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPilas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnPilas.FlatAppearance.BorderSize = 0;
            this.btnPilas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnPilas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilas.ForeColor = System.Drawing.Color.White;
            this.btnPilas.Location = new System.Drawing.Point(970, 356);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(107, 47);
            this.btnPilas.TabIndex = 4;
            this.btnPilas.Text = "Pilas";
            this.btnPilas.UseVisualStyleBackColor = false;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnColas
            // 
            this.btnColas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnColas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnColas.FlatAppearance.BorderSize = 0;
            this.btnColas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnColas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColas.ForeColor = System.Drawing.Color.White;
            this.btnColas.Location = new System.Drawing.Point(809, 479);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(107, 47);
            this.btnColas.TabIndex = 5;
            this.btnColas.Text = "Colas";
            this.btnColas.UseVisualStyleBackColor = false;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoED_CARS.Properties.Resources.link_Zelda_pixelart;
            this.pictureBox1.Location = new System.Drawing.Point(71, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1191, 705);
            this.Controls.Add(this.btnColas);
            this.Controls.Add(this.btnPilas);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button btnColas;
    }
}


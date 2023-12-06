namespace ProyectoED_CARS
{
    partial class EDpilas
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtB_genero = new System.Windows.Forms.TextBox();
            this.txtB_precio = new System.Windows.Forms.TextBox();
            this.txtB_titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_buscar = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPlataformas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "plataforma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "presio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "titulo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PC",
            "Xbox",
            "Play",
            "Switch"});
            this.comboBox1.Location = new System.Drawing.Point(646, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // txtB_genero
            // 
            this.txtB_genero.Location = new System.Drawing.Point(646, 317);
            this.txtB_genero.Name = "txtB_genero";
            this.txtB_genero.Size = new System.Drawing.Size(100, 20);
            this.txtB_genero.TabIndex = 27;
            // 
            // txtB_precio
            // 
            this.txtB_precio.Location = new System.Drawing.Point(646, 257);
            this.txtB_precio.Name = "txtB_precio";
            this.txtB_precio.Size = new System.Drawing.Size(100, 20);
            this.txtB_precio.TabIndex = 26;
            // 
            // txtB_titulo
            // 
            this.txtB_titulo.Location = new System.Drawing.Point(646, 200);
            this.txtB_titulo.Name = "txtB_titulo";
            this.txtB_titulo.Size = new System.Drawing.Size(100, 20);
            this.txtB_titulo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "buscar juego";
            // 
            // txtB_buscar
            // 
            this.txtB_buscar.Location = new System.Drawing.Point(663, 92);
            this.txtB_buscar.Name = "txtB_buscar";
            this.txtB_buscar.Size = new System.Drawing.Size(100, 20);
            this.txtB_buscar.TabIndex = 23;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(296, 90);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CId,
            this.Ctitulo,
            this.CPrecio,
            this.CGenero,
            this.CPlataformas});
            this.dataGridView1.Location = new System.Drawing.Point(25, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(532, 225);
            this.dataGridView1.TabIndex = 21;
            // 
            // CId
            // 
            this.CId.HeaderText = "ID";
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
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
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(182, 90);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "modificar";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(413, 90);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(385, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pilas";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(34, 92);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "añadir";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(666, 125);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 34;
            this.btn_buscar.Text = "buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // EDpilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtB_genero);
            this.Controls.Add(this.txtB_precio);
            this.Controls.Add(this.txtB_titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_buscar);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Name = "EDpilas";
            this.Text = "EDpilas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtB_genero;
        private System.Windows.Forms.TextBox txtB_precio;
        private System.Windows.Forms.TextBox txtB_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_buscar;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlataformas;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_buscar;
    }
}
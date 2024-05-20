namespace BibliotecaFrom
{
	partial class FrmAdministrarBiblioteca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.txtEliminarPorID = new System.Windows.Forms.TextBox();
            this.btnEliminaeL = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.lbl_TipoTabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.ForeColor = System.Drawing.Color.Black;
            this.btnAtras.Location = new System.Drawing.Point(29, 575);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.Text = "Atras ";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Location = new System.Drawing.Point(120, 69);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(79, 44);
            this.btnUsuarios.TabIndex = 17;
            this.btnUsuarios.Text = "Ver tabla Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.Black;
            this.btnLibros.Location = new System.Drawing.Point(205, 69);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(79, 44);
            this.btnLibros.TabIndex = 19;
            this.btnLibros.Text = "Ver tabla Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.BackColor = System.Drawing.Color.Red;
            this.btnEliminarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarU.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarU.Location = new System.Drawing.Point(375, 69);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(79, 44);
            this.btnEliminarU.TabIndex = 20;
            this.btnEliminarU.Text = "Eliminar Usuario";
            this.btnEliminarU.UseVisualStyleBackColor = false;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToOrderColumns = true;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.Black;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrar.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMostrar.Location = new System.Drawing.Point(40, 185);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersVisible = false;
            this.dgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrar.Size = new System.Drawing.Size(870, 340);
            this.dgvMostrar.TabIndex = 23;
            this.dgvMostrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellClick);
            // 
            // txtEliminarPorID
            // 
            this.txtEliminarPorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminarPorID.Location = new System.Drawing.Point(787, 75);
            this.txtEliminarPorID.Name = "txtEliminarPorID";
            this.txtEliminarPorID.Size = new System.Drawing.Size(62, 31);
            this.txtEliminarPorID.TabIndex = 26;
            // 
            // btnEliminaeL
            // 
            this.btnEliminaeL.BackColor = System.Drawing.Color.Red;
            this.btnEliminaeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaeL.ForeColor = System.Drawing.Color.Black;
            this.btnEliminaeL.Location = new System.Drawing.Point(460, 69);
            this.btnEliminaeL.Name = "btnEliminaeL";
            this.btnEliminaeL.Size = new System.Drawing.Size(79, 44);
            this.btnEliminaeL.TabIndex = 24;
            this.btnEliminaeL.Text = "Eliminar Libro";
            this.btnEliminaeL.UseVisualStyleBackColor = false;
            this.btnEliminaeL.Click += new System.EventHandler(this.btnEliminaeL_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.Black;
            this.btnPrestamos.Location = new System.Drawing.Point(290, 69);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(79, 44);
            this.btnPrestamos.TabIndex = 27;
            this.btnPrestamos.Text = "Ver tabla Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarLibro.Location = new System.Drawing.Point(35, 69);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(79, 44);
            this.btnAgregarLibro.TabIndex = 32;
            this.btnAgregarLibro.Text = "Agregar libro";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(630, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ingrese o seleccione el ID del \r\nelemento a eliminar:";
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.Color.Red;
            this.btnEliminarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarP.Location = new System.Drawing.Point(545, 69);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(79, 44);
            this.btnEliminarP.TabIndex = 34;
            this.btnEliminarP.Text = "Eliminar Prestamo";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // lbl_TipoTabla
            // 
            this.lbl_TipoTabla.AutoSize = true;
            this.lbl_TipoTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoTabla.ForeColor = System.Drawing.Color.Black;
            this.lbl_TipoTabla.Location = new System.Drawing.Point(36, 139);
            this.lbl_TipoTabla.Name = "lbl_TipoTabla";
            this.lbl_TipoTabla.Size = new System.Drawing.Size(68, 24);
            this.lbl_TipoTabla.TabIndex = 35;
            this.lbl_TipoTabla.Text = "Tabla ";
            // 
            // FrmAdministrarBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 642);
            this.Controls.Add(this.lbl_TipoTabla);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.txtEliminarPorID);
            this.Controls.Add(this.btnEliminaeL);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrarBiblioteca";
            this.Text = "Administrar Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAtras;
		private System.Windows.Forms.Button btnUsuarios;
		private System.Windows.Forms.Button btnLibros;
		private System.Windows.Forms.Button btnEliminarU;
		private System.Windows.Forms.DataGridView dgvMostrar;
		private System.Windows.Forms.TextBox txtEliminarPorID;
		private System.Windows.Forms.Button btnEliminaeL;
		private System.Windows.Forms.Button btnPrestamos;
		private System.Windows.Forms.Button btnAgregarLibro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Label lbl_TipoTabla;
    }
}
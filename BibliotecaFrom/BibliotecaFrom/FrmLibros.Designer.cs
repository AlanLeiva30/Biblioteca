namespace BibliotecaFrom
{
	partial class FrmLibros
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
            this.btnPrestar = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lbl_IdUsuario = new System.Windows.Forms.Label();
            this.lbl_IdDeUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SeleccioneLibro = new System.Windows.Forms.Label();
            this.lbl_IdLibro = new System.Windows.Forms.Label();
            this.lbl_Libro_seleccionado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrestar
            // 
            this.btnPrestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrestar.Location = new System.Drawing.Point(719, 614);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(155, 55);
            this.btnPrestar.TabIndex = 7;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = false;
            this.btnPrestar.Visible = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.EnableHeadersVisualStyles = false;
            this.dgvMostrar.Location = new System.Drawing.Point(80, 254);
            this.dgvMostrar.MultiSelect = false;
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersVisible = false;
            this.dgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrar.ShowEditingIcon = false;
            this.dgvMostrar.Size = new System.Drawing.Size(794, 318);
            this.dgvMostrar.TabIndex = 24;
            this.dgvMostrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellClick);
            // 
            // lbl_IdUsuario
            // 
            this.lbl_IdUsuario.AutoSize = true;
            this.lbl_IdUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdUsuario.Location = new System.Drawing.Point(861, 161);
            this.lbl_IdUsuario.Name = "lbl_IdUsuario";
            this.lbl_IdUsuario.Size = new System.Drawing.Size(13, 13);
            this.lbl_IdUsuario.TabIndex = 25;
            this.lbl_IdUsuario.Text = "--";
            this.lbl_IdUsuario.Visible = false;
            // 
            // lbl_IdDeUsuario
            // 
            this.lbl_IdDeUsuario.AutoSize = true;
            this.lbl_IdDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdDeUsuario.Location = new System.Drawing.Point(784, 161);
            this.lbl_IdDeUsuario.Name = "lbl_IdDeUsuario";
            this.lbl_IdDeUsuario.Size = new System.Drawing.Size(71, 13);
            this.lbl_IdDeUsuario.TabIndex = 26;
            this.lbl_IdDeUsuario.Text = "Id de usuario:";
            this.lbl_IdDeUsuario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(75, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Prestamo de libros";
            // 
            // lbl_SeleccioneLibro
            // 
            this.lbl_SeleccioneLibro.AutoSize = true;
            this.lbl_SeleccioneLibro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SeleccioneLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SeleccioneLibro.Location = new System.Drawing.Point(77, 121);
            this.lbl_SeleccioneLibro.Name = "lbl_SeleccioneLibro";
            this.lbl_SeleccioneLibro.Size = new System.Drawing.Size(231, 16);
            this.lbl_SeleccioneLibro.TabIndex = 28;
            this.lbl_SeleccioneLibro.Text = "Seleccione el libro que desea prestar";
            this.lbl_SeleccioneLibro.Visible = false;
            // 
            // lbl_IdLibro
            // 
            this.lbl_IdLibro.AutoSize = true;
            this.lbl_IdLibro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdLibro.Location = new System.Drawing.Point(688, 586);
            this.lbl_IdLibro.Name = "lbl_IdLibro";
            this.lbl_IdLibro.Size = new System.Drawing.Size(73, 20);
            this.lbl_IdLibro.TabIndex = 29;
            this.lbl_IdLibro.Text = "ninguno";
            this.lbl_IdLibro.Visible = false;
            // 
            // lbl_Libro_seleccionado
            // 
            this.lbl_Libro_seleccionado.AutoSize = true;
            this.lbl_Libro_seleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Libro_seleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Libro_seleccionado.Location = new System.Drawing.Point(525, 586);
            this.lbl_Libro_seleccionado.Name = "lbl_Libro_seleccionado";
            this.lbl_Libro_seleccionado.Size = new System.Drawing.Size(157, 20);
            this.lbl_Libro_seleccionado.TabIndex = 30;
            this.lbl_Libro_seleccionado.Text = "Id libro seleccionado:";
            this.lbl_Libro_seleccionado.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Lista de libros disponibles";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.Location = new System.Drawing.Point(80, 600);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(155, 55);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrestamos.Location = new System.Drawing.Point(719, 177);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(155, 55);
            this.btnPrestamos.TabIndex = 33;
            this.btnPrestamos.Text = "Ver prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Visible = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaFrom.Properties.Resources.pngtree_book_incense_china_national_reading_publicity_poster_background_material_image_154003;
            this.ClientSize = new System.Drawing.Size(963, 681);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Libro_seleccionado);
            this.Controls.Add(this.lbl_IdLibro);
            this.Controls.Add(this.lbl_SeleccioneLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_IdDeUsuario);
            this.Controls.Add(this.lbl_IdUsuario);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.btnPrestar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLibros";
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnPrestar;
		private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lbl_IdUsuario;
        private System.Windows.Forms.Label lbl_IdDeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SeleccioneLibro;
        private System.Windows.Forms.Label lbl_IdLibro;
        private System.Windows.Forms.Label lbl_Libro_seleccionado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnPrestamos;
    }
}
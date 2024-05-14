namespace BibliotecaFrom
{
	partial class FrmAgregarLibro
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
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpbLibro = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gpbLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(15, 73);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(39, 12);
            this.lblAutor.TabIndex = 26;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(39, 12);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(15, 104);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(118, 12);
            this.lblAño.TabIndex = 28;
            this.lblAño.Text = "Año de publicacion :";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(60, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(297, 20);
            this.txtTitulo.TabIndex = 25;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(15, 140);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(65, 12);
            this.lblContenido.TabIndex = 29;
            this.lblContenido.Text = "Contenido:";
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(82, 132);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(275, 20);
            this.txtContenido.TabIndex = 30;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(139, 96);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(218, 20);
            this.txtAño.TabIndex = 31;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(60, 65);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(297, 20);
            this.txtAutor.TabIndex = 32;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Red;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(159, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpbLibro
            // 
            this.gpbLibro.Controls.Add(this.btnAgregar);
            this.gpbLibro.Controls.Add(this.txtAutor);
            this.gpbLibro.Controls.Add(this.txtAño);
            this.gpbLibro.Controls.Add(this.txtContenido);
            this.gpbLibro.Controls.Add(this.lblContenido);
            this.gpbLibro.Controls.Add(this.txtTitulo);
            this.gpbLibro.Controls.Add(this.lblAño);
            this.gpbLibro.Controls.Add(this.lblTitulo);
            this.gpbLibro.Controls.Add(this.lblAutor);
            this.gpbLibro.Location = new System.Drawing.Point(156, 68);
            this.gpbLibro.Name = "gpbLibro";
            this.gpbLibro.Size = new System.Drawing.Size(387, 231);
            this.gpbLibro.TabIndex = 29;
            this.gpbLibro.TabStop = false;
            this.gpbLibro.Text = "Agregar Libro";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.Location = new System.Drawing.Point(-1, 340);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 30;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaFrom.Properties.Resources.pngtree_cartoon_dream_reading_life_change_poster_background_material_image_151816;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 375);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gpbLibro);
            this.Name = "FrmAgregarLibro";
            this.Text = "Agregar Libro";
            this.gpbLibro.ResumeLayout(false);
            this.gpbLibro.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblAutor;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblAño;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label lblContenido;
		private System.Windows.Forms.TextBox txtContenido;
		private System.Windows.Forms.TextBox txtAño;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.GroupBox gpbLibro;
        private System.Windows.Forms.Button btnAtras;
    }
}
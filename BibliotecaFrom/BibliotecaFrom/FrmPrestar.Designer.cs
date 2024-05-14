namespace BibliotecaFrom
{
	partial class FrmPrestar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDevolusion = new System.Windows.Forms.Label();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpDevolusion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lbl_TituloLibro = new System.Windows.Forms.Label();
            this.lbl_UsuarioPrestamo = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 98);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo del libro:";
            // 
            // lblDevolusion
            // 
            this.lblDevolusion.AutoSize = true;
            this.lblDevolusion.BackColor = System.Drawing.Color.Transparent;
            this.lblDevolusion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolusion.Location = new System.Drawing.Point(12, 213);
            this.lblDevolusion.Name = "lblDevolusion";
            this.lblDevolusion.Size = new System.Drawing.Size(177, 18);
            this.lblDevolusion.TabIndex = 1;
            this.lblDevolusion.Text = "Fecha de devolusion:";
            // 
            // btnPrestar
            // 
            this.btnPrestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrestar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrestar.Location = new System.Drawing.Point(289, 297);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(109, 43);
            this.btnPrestar.TabIndex = 2;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 18);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Usuario:";
            // 
            // dtpDevolusion
            // 
            this.dtpDevolusion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolusion.Location = new System.Drawing.Point(197, 207);
            this.dtpDevolusion.Name = "dtpDevolusion";
            this.dtpDevolusion.Size = new System.Drawing.Size(318, 26);
            this.dtpDevolusion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de prestamo:";
            // 
            // dtpPrestamo
            // 
            this.dtpPrestamo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrestamo.Location = new System.Drawing.Point(197, 149);
            this.dtpPrestamo.Name = "dtpPrestamo";
            this.dtpPrestamo.Size = new System.Drawing.Size(318, 26);
            this.dtpPrestamo.TabIndex = 9;
            // 
            // lbl_TituloLibro
            // 
            this.lbl_TituloLibro.AutoSize = true;
            this.lbl_TituloLibro.BackColor = System.Drawing.Color.White;
            this.lbl_TituloLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloLibro.ForeColor = System.Drawing.Color.Black;
            this.lbl_TituloLibro.Location = new System.Drawing.Point(219, 98);
            this.lbl_TituloLibro.Name = "lbl_TituloLibro";
            this.lbl_TituloLibro.Size = new System.Drawing.Size(109, 24);
            this.lbl_TituloLibro.TabIndex = 10;
            this.lbl_TituloLibro.Text = "TituloLibro";
            // 
            // lbl_UsuarioPrestamo
            // 
            this.lbl_UsuarioPrestamo.AutoSize = true;
            this.lbl_UsuarioPrestamo.BackColor = System.Drawing.Color.White;
            this.lbl_UsuarioPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuarioPrestamo.Location = new System.Drawing.Point(193, 50);
            this.lbl_UsuarioPrestamo.Name = "lbl_UsuarioPrestamo";
            this.lbl_UsuarioPrestamo.Size = new System.Drawing.Size(168, 24);
            this.lbl_UsuarioPrestamo.TabIndex = 11;
            this.lbl_UsuarioPrestamo.Text = "UsuarioPrestamo";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.Location = new System.Drawing.Point(289, 358);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 36);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrmPrestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::BibliotecaFrom.Properties.Resources.libreria;
            this.ClientSize = new System.Drawing.Size(1055, 530);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lbl_UsuarioPrestamo);
            this.Controls.Add(this.lbl_TituloLibro);
            this.Controls.Add(this.dtpPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDevolusion);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.lblDevolusion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPrestar";
            this.Text = "Prestar libro";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblDevolusion;
		private System.Windows.Forms.Button btnPrestar;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.DateTimePicker dtpDevolusion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPrestamo;
        private System.Windows.Forms.Label lbl_TituloLibro;
        private System.Windows.Forms.Label lbl_UsuarioPrestamo;
        private System.Windows.Forms.Button btnAtras;
    }
}
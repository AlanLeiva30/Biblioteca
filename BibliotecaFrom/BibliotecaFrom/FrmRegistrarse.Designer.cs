namespace BibliotecaFrom
{
	partial class FrmRegistrarse
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
            this.gpbRegistrarse = new System.Windows.Forms.GroupBox();
            this.lblSuperUsuario = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ckbAdministrador = new System.Windows.Forms.CheckBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbRegistrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbRegistrarse
            // 
            this.gpbRegistrarse.Controls.Add(this.pictureBox1);
            this.gpbRegistrarse.Controls.Add(this.lblSuperUsuario);
            this.gpbRegistrarse.Controls.Add(this.btnLimpiar);
            this.gpbRegistrarse.Controls.Add(this.btnRegistrar);
            this.gpbRegistrarse.Controls.Add(this.txtCodigo);
            this.gpbRegistrarse.Controls.Add(this.ckbAdministrador);
            this.gpbRegistrarse.Controls.Add(this.txtCorreo);
            this.gpbRegistrarse.Controls.Add(this.txtDireccion);
            this.gpbRegistrarse.Controls.Add(this.txtTelefono);
            this.gpbRegistrarse.Controls.Add(this.txtContraseña);
            this.gpbRegistrarse.Controls.Add(this.txtUsuario);
            this.gpbRegistrarse.Controls.Add(this.txtNombre);
            this.gpbRegistrarse.Controls.Add(this.lblContraseña);
            this.gpbRegistrarse.Controls.Add(this.lblUsuario);
            this.gpbRegistrarse.Controls.Add(this.lblCorreo);
            this.gpbRegistrarse.Controls.Add(this.lblTelefono);
            this.gpbRegistrarse.Controls.Add(this.lblDireccion);
            this.gpbRegistrarse.Controls.Add(this.lblNombre);
            this.gpbRegistrarse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistrarse.Location = new System.Drawing.Point(134, 38);
            this.gpbRegistrarse.Name = "gpbRegistrarse";
            this.gpbRegistrarse.Size = new System.Drawing.Size(431, 365);
            this.gpbRegistrarse.TabIndex = 0;
            this.gpbRegistrarse.TabStop = false;
            this.gpbRegistrarse.Text = "Registrarse";
            // 
            // lblSuperUsuario
            // 
            this.lblSuperUsuario.AutoSize = true;
            this.lblSuperUsuario.Location = new System.Drawing.Point(162, 266);
            this.lblSuperUsuario.Name = "lblSuperUsuario";
            this.lblSuperUsuario.Size = new System.Drawing.Size(167, 12);
            this.lblSuperUsuario.TabIndex = 16;
            this.lblSuperUsuario.Text = "Contraseña de super usuario";
            this.lblSuperUsuario.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(202, 319);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(69, 319);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(164, 243);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(113, 20);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.Visible = false;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // ckbAdministrador
            // 
            this.ckbAdministrador.AutoSize = true;
            this.ckbAdministrador.Location = new System.Drawing.Point(55, 245);
            this.ckbAdministrador.Name = "ckbAdministrador";
            this.ckbAdministrador.Size = new System.Drawing.Size(103, 16);
            this.ckbAdministrador.TabIndex = 12;
            this.ckbAdministrador.Text = "Administrador";
            this.ckbAdministrador.UseVisualStyleBackColor = true;
            this.ckbAdministrador.CheckedChanged += new System.EventHandler(this.ckbAdministrador_CheckedChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(90, 140);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(237, 20);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(101, 75);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(226, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(97, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(101, 204);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(226, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(97, 172);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(27, 212);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(73, 12);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(27, 180);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(51, 12);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(30, 148);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 12);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(27, 117);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 12);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 78);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(62, 12);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 12);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Completo: ";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.Location = new System.Drawing.Point(12, 430);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BibliotecaFrom.Properties.Resources.reception_line_filled_backgroud_icon_vector;
            this.pictureBox1.Location = new System.Drawing.Point(337, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaFrom.Properties.Resources.pngtree_2_5d_simple_stereoscopic_financial_image_17488;
            this.ClientSize = new System.Drawing.Size(715, 468);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gpbRegistrarse);
            this.Name = "FrmRegistrarse";
            this.Text = "Registrarse";
            this.gpbRegistrarse.ResumeLayout(false);
            this.gpbRegistrarse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gpbRegistrarse;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.CheckBox ckbAdministrador;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Label lblSuperUsuario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
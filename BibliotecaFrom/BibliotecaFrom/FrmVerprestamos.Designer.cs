namespace BibliotecaFrom
{
	partial class FrmVerprestamos
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
            this.dgvVer = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btn_CancelarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVer
            // 
            this.dgvVer.AllowUserToAddRows = false;
            this.dgvVer.AllowUserToDeleteRows = false;
            this.dgvVer.AllowUserToResizeColumns = false;
            this.dgvVer.AllowUserToResizeRows = false;
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.EnableHeadersVisualStyles = false;
            this.dgvVer.Location = new System.Drawing.Point(27, 12);
            this.dgvVer.MultiSelect = false;
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.ReadOnly = true;
            this.dgvVer.RowHeadersVisible = false;
            this.dgvVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVer.Size = new System.Drawing.Size(407, 298);
            this.dgvVer.TabIndex = 35;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.Location = new System.Drawing.Point(27, 316);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 35);
            this.btnAtras.TabIndex = 36;
            this.btnAtras.Text = "Atras ";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btn_CancelarPrestamo
            // 
            this.btn_CancelarPrestamo.BackColor = System.Drawing.Color.Red;
            this.btn_CancelarPrestamo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CancelarPrestamo.Location = new System.Drawing.Point(357, 316);
            this.btn_CancelarPrestamo.Name = "btn_CancelarPrestamo";
            this.btn_CancelarPrestamo.Size = new System.Drawing.Size(77, 35);
            this.btn_CancelarPrestamo.TabIndex = 37;
            this.btn_CancelarPrestamo.Text = "Cancelar prestamo";
            this.btn_CancelarPrestamo.UseVisualStyleBackColor = false;
            this.btn_CancelarPrestamo.Click += new System.EventHandler(this.btn_CancelarPrestamo_Click);
            // 
            // FrmVerprestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaFrom.Properties.Resources.beautiful_arrangement_different_books_23_2148883798;
            this.ClientSize = new System.Drawing.Size(630, 351);
            this.Controls.Add(this.btn_CancelarPrestamo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvVer);
            this.Name = "FrmVerprestamos";
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvVer;
		private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btn_CancelarPrestamo;
    }
}
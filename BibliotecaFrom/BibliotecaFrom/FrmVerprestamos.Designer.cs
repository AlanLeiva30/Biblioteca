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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvVer.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVer.EnableHeadersVisualStyles = false;
            this.dgvVer.Location = new System.Drawing.Point(86, 42);
            this.dgvVer.MultiSelect = false;
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.ReadOnly = true;
            this.dgvVer.RowHeadersVisible = false;
            this.dgvVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVer.Size = new System.Drawing.Size(764, 463);
            this.dgvVer.TabIndex = 35;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.Location = new System.Drawing.Point(86, 553);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 50);
            this.btnAtras.TabIndex = 36;
            this.btnAtras.Text = "Atras ";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btn_CancelarPrestamo
            // 
            this.btn_CancelarPrestamo.BackColor = System.Drawing.Color.Red;
            this.btn_CancelarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CancelarPrestamo.Location = new System.Drawing.Point(705, 564);
            this.btn_CancelarPrestamo.Name = "btn_CancelarPrestamo";
            this.btn_CancelarPrestamo.Size = new System.Drawing.Size(145, 50);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 642);
            this.Controls.Add(this.btn_CancelarPrestamo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
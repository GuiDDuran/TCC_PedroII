namespace WindowsFormsApp1
{
	partial class GerarProntuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarProntuario));
            this.txtBuscaPac = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblPacAbuscar = new System.Windows.Forms.Label();
            this.lblDescritivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscaPac
            // 
            this.txtBuscaPac.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBuscaPac.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaPac.Location = new System.Drawing.Point(801, 168);
            this.txtBuscaPac.Multiline = true;
            this.txtBuscaPac.Name = "txtBuscaPac";
            this.txtBuscaPac.Size = new System.Drawing.Size(177, 29);
            this.txtBuscaPac.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1007, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbBuscar.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(801, 224);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(177, 29);
            this.cmbBuscar.TabIndex = 40;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // lblPacAbuscar
            // 
            this.lblPacAbuscar.AutoSize = true;
            this.lblPacAbuscar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacAbuscar.Location = new System.Drawing.Point(263, 168);
            this.lblPacAbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPacAbuscar.Name = "lblPacAbuscar";
            this.lblPacAbuscar.Size = new System.Drawing.Size(606, 32);
            this.lblPacAbuscar.TabIndex = 41;
            this.lblPacAbuscar.Text = "Digite o nome do paciente que desja gerar prontuário:";
            // 
            // lblDescritivo
            // 
            this.lblDescritivo.AutoSize = true;
            this.lblDescritivo.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescritivo.Location = new System.Drawing.Point(574, 23);
            this.lblDescritivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescritivo.Name = "lblDescritivo";
            this.lblDescritivo.Size = new System.Drawing.Size(413, 65);
            this.lblDescritivo.TabIndex = 42;
            this.lblDescritivo.Text = "Gerar Prontuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1196, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // GerarProntuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1444, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescritivo);
            this.Controls.Add(this.lblPacAbuscar);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscaPac);
            this.Name = "GerarProntuario";
            this.Text = "GerarProntuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GerarProntuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBuscaPac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label lblPacAbuscar;
        private System.Windows.Forms.Label lblDescritivo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
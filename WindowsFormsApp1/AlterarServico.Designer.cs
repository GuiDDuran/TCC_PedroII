namespace WindowsFormsApp1
{
	partial class AlterarServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarServico));
            this.clbDia = new System.Windows.Forms.CheckedListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtBuscaServ = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblQntd = new System.Windows.Forms.Label();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.lblDescritivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clbDia
            // 
            this.clbDia.BackColor = System.Drawing.SystemColors.Menu;
            this.clbDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDia.Enabled = false;
            this.clbDia.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDia.FormattingEnabled = true;
            this.clbDia.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta"});
            this.clbDia.Location = new System.Drawing.Point(552, 308);
            this.clbDia.Margin = new System.Windows.Forms.Padding(4);
            this.clbDia.Name = "clbDia";
            this.clbDia.Size = new System.Drawing.Size(194, 104);
            this.clbDia.TabIndex = 21;
            this.clbDia.SelectedIndexChanged += new System.EventHandler(this.clbDia_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCancelar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1103, 563);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 64);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(272, 308);
            this.lblDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(65, 32);
            this.lblDia.TabIndex = 18;
            this.lblDia.Text = "Dias:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(272, 269);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(67, 32);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(272, 222);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(75, 32);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Valor:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(272, 130);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 32);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(552, 269);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(177, 31);
            this.txtTipo.TabIndex = 14;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(552, 222);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(177, 31);
            this.txtValor.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(552, 130);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 31);
            this.txtNome.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1103, 134);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(211, 64);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAlterar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(278, 563);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(211, 64);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExcluir.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(706, 563);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(211, 64);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBuscaServ
            // 
            this.txtBuscaServ.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBuscaServ.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaServ.Location = new System.Drawing.Point(906, 134);
            this.txtBuscaServ.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaServ.Name = "txtBuscaServ";
            this.txtBuscaServ.Size = new System.Drawing.Size(177, 31);
            this.txtBuscaServ.TabIndex = 25;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbBuscar.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(906, 176);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(177, 29);
            this.cmbBuscar.TabIndex = 26;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // lblQntd
            // 
            this.lblQntd.AutoSize = true;
            this.lblQntd.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntd.Location = new System.Drawing.Point(272, 174);
            this.lblQntd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQntd.Name = "lblQntd";
            this.lblQntd.Size = new System.Drawing.Size(272, 32);
            this.lblQntd.TabIndex = 27;
            this.lblQntd.Text = "Quantidade de Sessões:";
            this.lblQntd.Click += new System.EventHandler(this.lblQntd_Click);
            // 
            // txtQntd
            // 
            this.txtQntd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQntd.Enabled = false;
            this.txtQntd.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntd.Location = new System.Drawing.Point(552, 174);
            this.txtQntd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(177, 31);
            this.txtQntd.TabIndex = 28;
            // 
            // lblDescritivo
            // 
            this.lblDescritivo.AutoSize = true;
            this.lblDescritivo.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescritivo.Location = new System.Drawing.Point(524, 24);
            this.lblDescritivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescritivo.Name = "lblDescritivo";
            this.lblDescritivo.Size = new System.Drawing.Size(497, 65);
            this.lblDescritivo.TabIndex = 29;
            this.lblDescritivo.Text = "Alteração de Serviço";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1250, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // AlterarServico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1444, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescritivo);
            this.Controls.Add(this.txtQntd);
            this.Controls.Add(this.lblQntd);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.txtBuscaServ);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.clbDia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlterarServico";
            this.Text = "AlterarServico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AlterarServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clbDia;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblDia;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBuscaServ;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label lblQntd;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.Label lblDescritivo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
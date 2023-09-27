namespace WindowsFormsApp1
{
	partial class CadastrarSessao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarSessao));
            this.dgvServ = new System.Windows.Forms.DataGridView();
            this.btnBuscarServ = new System.Windows.Forms.Button();
            this.dgvPac = new System.Windows.Forms.DataGridView();
            this.btnBuscarPac = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtListServ = new System.Windows.Forms.TextBox();
            this.txtListPac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomePac = new System.Windows.Forms.Label();
            this.lblNomeServ = new System.Windows.Forms.Label();
            this.dtpSessao = new System.Windows.Forms.DateTimePicker();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cmbProfissional = new System.Windows.Forms.ComboBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServ
            // 
            this.dgvServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServ.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServ.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServ.Location = new System.Drawing.Point(812, 177);
            this.dgvServ.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServ.Name = "dgvServ";
            this.dgvServ.ReadOnly = true;
            this.dgvServ.Size = new System.Drawing.Size(620, 185);
            this.dgvServ.TabIndex = 14;
            this.dgvServ.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvServ_CellMouseClick);
            // 
            // btnBuscarServ
            // 
            this.btnBuscarServ.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscarServ.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServ.Location = new System.Drawing.Point(1316, 133);
            this.btnBuscarServ.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarServ.Name = "btnBuscarServ";
            this.btnBuscarServ.Size = new System.Drawing.Size(106, 33);
            this.btnBuscarServ.TabIndex = 13;
            this.btnBuscarServ.Text = "Buscar";
            this.btnBuscarServ.UseVisualStyleBackColor = false;
            this.btnBuscarServ.Click += new System.EventHandler(this.btnBuscarServ_Click);
            // 
            // dgvPac
            // 
            this.dgvPac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPac.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPac.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPac.Location = new System.Drawing.Point(51, 177);
            this.dgvPac.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPac.Name = "dgvPac";
            this.dgvPac.ReadOnly = true;
            this.dgvPac.Size = new System.Drawing.Size(619, 185);
            this.dgvPac.TabIndex = 11;
            this.dgvPac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPac_CellContentClick);
            this.dgvPac.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPac_CellMouseClick);
            // 
            // btnBuscarPac
            // 
            this.btnBuscarPac.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscarPac.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPac.Location = new System.Drawing.Point(564, 133);
            this.btnBuscarPac.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPac.Name = "btnBuscarPac";
            this.btnBuscarPac.Size = new System.Drawing.Size(106, 33);
            this.btnBuscarPac.TabIndex = 10;
            this.btnBuscarPac.Text = "Buscar";
            this.btnBuscarPac.UseVisualStyleBackColor = false;
            this.btnBuscarPac.Click += new System.EventHandler(this.btnBuscarPac_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCadastrar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(532, 626);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(211, 64);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar Sessão";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtListServ
            // 
            this.txtListServ.BackColor = System.Drawing.SystemColors.Menu;
            this.txtListServ.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListServ.Location = new System.Drawing.Point(1118, 133);
            this.txtListServ.Margin = new System.Windows.Forms.Padding(4);
            this.txtListServ.Multiline = true;
            this.txtListServ.Name = "txtListServ";
            this.txtListServ.Size = new System.Drawing.Size(177, 29);
            this.txtListServ.TabIndex = 20;
            this.txtListServ.TextChanged += new System.EventHandler(this.txtListServ_TextChanged);
            // 
            // txtListPac
            // 
            this.txtListPac.BackColor = System.Drawing.SystemColors.Menu;
            this.txtListPac.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListPac.Location = new System.Drawing.Point(364, 136);
            this.txtListPac.Margin = new System.Windows.Forms.Padding(4);
            this.txtListPac.Multiline = true;
            this.txtListPac.Name = "txtListPac";
            this.txtListPac.Size = new System.Drawing.Size(177, 29);
            this.txtListPac.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 65);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastro de Sessão";
            // 
            // lblNomePac
            // 
            this.lblNomePac.AutoSize = true;
            this.lblNomePac.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePac.Location = new System.Drawing.Point(45, 132);
            this.lblNomePac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePac.Name = "lblNomePac";
            this.lblNomePac.Size = new System.Drawing.Size(311, 32);
            this.lblNomePac.TabIndex = 23;
            this.lblNomePac.Text = "Digite o nome do paciente:";
            this.lblNomePac.Click += new System.EventHandler(this.lblNomePac_Click);
            // 
            // lblNomeServ
            // 
            this.lblNomeServ.AutoSize = true;
            this.lblNomeServ.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeServ.Location = new System.Drawing.Point(807, 132);
            this.lblNomeServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeServ.Name = "lblNomeServ";
            this.lblNomeServ.Size = new System.Drawing.Size(294, 32);
            this.lblNomeServ.TabIndex = 24;
            this.lblNomeServ.Text = "Digite o nome do serviço:";
            this.lblNomeServ.Click += new System.EventHandler(this.lblNomeServ_Click);
            // 
            // dtpSessao
            // 
            this.dtpSessao.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpSessao.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSessao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSessao.Location = new System.Drawing.Point(364, 494);
            this.dtpSessao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSessao.Name = "dtpSessao";
            this.dtpSessao.Size = new System.Drawing.Size(177, 31);
            this.dtpSessao.TabIndex = 25;
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbPagamento.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "Pix",
            "Cheque",
            "Dinheiro",
            "Cartão de Débito",
            "Cartão de Crédito",
            "Transferência Bancária"});
            this.cmbPagamento.Location = new System.Drawing.Point(364, 426);
            this.cmbPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(177, 29);
            this.cmbPagamento.TabIndex = 26;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(78, 425);
            this.lblPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(252, 32);
            this.lblPagamento.TabIndex = 27;
            this.lblPagamento.Text = "Forma de pagamento:";
            this.lblPagamento.Click += new System.EventHandler(this.lblPagamento_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(78, 496);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(217, 32);
            this.lblData.TabIndex = 28;
            this.lblData.Text = "Data de realização:";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(807, 426);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(156, 32);
            this.lblObservacao.TabIndex = 29;
            this.lblObservacao.Text = "Observações:";
            this.lblObservacao.Click += new System.EventHandler(this.lblObservacao_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtObservacao.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(1014, 431);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(244, 90);
            this.txtObservacao.TabIndex = 30;
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.Location = new System.Drawing.Point(364, 558);
            this.cmbProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(177, 30);
            this.cmbProfissional.TabIndex = 31;
            this.cmbProfissional.SelectedIndexChanged += new System.EventHandler(this.cmbProfissional_SelectedIndexChanged);
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(78, 560);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(142, 32);
            this.lblProf.TabIndex = 32;
            this.lblProf.Text = "Profissional:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(762, 626);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 64);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1269, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarSessao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1444, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.cmbPagamento);
            this.Controls.Add(this.dtpSessao);
            this.Controls.Add(this.lblNomeServ);
            this.Controls.Add(this.lblNomePac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListPac);
            this.Controls.Add(this.txtListServ);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvServ);
            this.Controls.Add(this.btnBuscarServ);
            this.Controls.Add(this.dgvPac);
            this.Controls.Add(this.btnBuscarPac);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarSessao";
            this.Text = "CadastrarSessao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarSessao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvServ;
		private System.Windows.Forms.Button btnBuscarServ;
		private System.Windows.Forms.DataGridView dgvPac;
		private System.Windows.Forms.Button btnBuscarPac;
		private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtListServ;
        private System.Windows.Forms.TextBox txtListPac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomePac;
        private System.Windows.Forms.Label lblNomeServ;
        private System.Windows.Forms.DateTimePicker dtpSessao;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cmbProfissional;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
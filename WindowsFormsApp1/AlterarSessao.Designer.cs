namespace WindowsFormsApp1
{
    partial class AlterarSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSessao));
            this.lblBuscaPac = new System.Windows.Forms.Label();
            this.txtBuscaPac = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.btnBuscaPac = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cmbFormaPag = new System.Windows.Forms.ComboBox();
            this.dtpSessao = new System.Windows.Forms.DateTimePicker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblDescritivo = new System.Windows.Forms.Label();
            this.cmbSelectSessao = new System.Windows.Forms.ComboBox();
            this.lblBuscaSessao = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.cmbProfissional = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscaPac
            // 
            this.lblBuscaPac.AutoSize = true;
            this.lblBuscaPac.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaPac.Location = new System.Drawing.Point(716, 156);
            this.lblBuscaPac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscaPac.Name = "lblBuscaPac";
            this.lblBuscaPac.Size = new System.Drawing.Size(311, 32);
            this.lblBuscaPac.TabIndex = 0;
            this.lblBuscaPac.Text = "Digite o nome do paciente:";
            // 
            // txtBuscaPac
            // 
            this.txtBuscaPac.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBuscaPac.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaPac.Location = new System.Drawing.Point(1050, 157);
            this.txtBuscaPac.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaPac.Name = "txtBuscaPac";
            this.txtBuscaPac.Size = new System.Drawing.Size(177, 31);
            this.txtBuscaPac.TabIndex = 1;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbBuscar.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(1050, 199);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(177, 29);
            this.cmbBuscar.TabIndex = 2;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // cmbServico
            // 
            this.cmbServico.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbServico.Enabled = false;
            this.cmbServico.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(319, 159);
            this.cmbServico.Margin = new System.Windows.Forms.Padding(4);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(177, 29);
            this.cmbServico.TabIndex = 3;
            this.cmbServico.SelectedIndexChanged += new System.EventHandler(this.cmbServico_SelectedIndexChanged);
            // 
            // btnBuscaPac
            // 
            this.btnBuscaPac.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPac.Location = new System.Drawing.Point(1247, 157);
            this.btnBuscaPac.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaPac.Name = "btnBuscaPac";
            this.btnBuscaPac.Size = new System.Drawing.Size(211, 64);
            this.btnBuscaPac.TabIndex = 4;
            this.btnBuscaPac.Text = "Buscar";
            this.btnBuscaPac.UseVisualStyleBackColor = true;
            this.btnBuscaPac.Click += new System.EventHandler(this.btnBuscaPac_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(319, 344);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(244, 90);
            this.txtObservacao.TabIndex = 6;
            // 
            // cmbFormaPag
            // 
            this.cmbFormaPag.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbFormaPag.Enabled = false;
            this.cmbFormaPag.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPag.FormattingEnabled = true;
            this.cmbFormaPag.Items.AddRange(new object[] {
            "Pix",
            "Cheque",
            "Dinheiro",
            "Cartão de Débito",
            "Cartão de Crédito",
            "Tranferência Bancária"});
            this.cmbFormaPag.Location = new System.Drawing.Point(319, 202);
            this.cmbFormaPag.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFormaPag.Name = "cmbFormaPag";
            this.cmbFormaPag.Size = new System.Drawing.Size(177, 29);
            this.cmbFormaPag.TabIndex = 7;
            // 
            // dtpSessao
            // 
            this.dtpSessao.Enabled = false;
            this.dtpSessao.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSessao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSessao.Location = new System.Drawing.Point(319, 250);
            this.dtpSessao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSessao.Name = "dtpSessao";
            this.dtpSessao.Size = new System.Drawing.Size(177, 31);
            this.dtpSessao.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(284, 563);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(211, 64);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(706, 563);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(211, 64);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1103, 563);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 64);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(60, 156);
            this.lblServico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(97, 32);
            this.lblServico.TabIndex = 13;
            this.lblServico.Text = "Serviço:";
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPag.Location = new System.Drawing.Point(59, 199);
            this.lblFormaPag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(252, 32);
            this.lblFormaPag.TabIndex = 14;
            this.lblFormaPag.Text = "Forma de pagamento:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(59, 249);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(217, 32);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data de realização:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(60, 343);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(145, 32);
            this.lblObservacao.TabIndex = 16;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblDescritivo
            // 
            this.lblDescritivo.AutoSize = true;
            this.lblDescritivo.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescritivo.Location = new System.Drawing.Point(541, 23);
            this.lblDescritivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescritivo.Name = "lblDescritivo";
            this.lblDescritivo.Size = new System.Drawing.Size(486, 65);
            this.lblDescritivo.TabIndex = 17;
            this.lblDescritivo.Text = "Alteração de Sessão";
            // 
            // cmbSelectSessao
            // 
            this.cmbSelectSessao.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSelectSessao.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectSessao.FormattingEnabled = true;
            this.cmbSelectSessao.Location = new System.Drawing.Point(1050, 251);
            this.cmbSelectSessao.Name = "cmbSelectSessao";
            this.cmbSelectSessao.Size = new System.Drawing.Size(177, 29);
            this.cmbSelectSessao.TabIndex = 18;
            this.cmbSelectSessao.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSessao_SelectedIndexChanged);
            // 
            // lblBuscaSessao
            // 
            this.lblBuscaSessao.AutoSize = true;
            this.lblBuscaSessao.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaSessao.Location = new System.Drawing.Point(655, 247);
            this.lblBuscaSessao.Name = "lblBuscaSessao";
            this.lblBuscaSessao.Size = new System.Drawing.Size(372, 32);
            this.lblBuscaSessao.TabIndex = 19;
            this.lblBuscaSessao.Text = "Selecione a sessão a ser alterada:";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(60, 296);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(142, 32);
            this.lblProf.TabIndex = 20;
            this.lblProf.Text = "Profissional:";
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.Enabled = false;
            this.cmbProfissional.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.Location = new System.Drawing.Point(319, 297);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(177, 27);
            this.cmbProfissional.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1229, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // AlterarSessao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1444, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblBuscaSessao);
            this.Controls.Add(this.cmbSelectSessao);
            this.Controls.Add(this.lblDescritivo);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dtpSessao);
            this.Controls.Add(this.cmbFormaPag);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.btnBuscaPac);
            this.Controls.Add(this.cmbServico);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.txtBuscaPac);
            this.Controls.Add(this.lblBuscaPac);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlterarSessao";
            this.Text = "AlterarSessao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AlterarSessao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscaPac;
        private System.Windows.Forms.TextBox txtBuscaPac;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Button btnBuscaPac;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cmbFormaPag;
        private System.Windows.Forms.DateTimePicker dtpSessao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblDescritivo;
        private System.Windows.Forms.ComboBox cmbSelectSessao;
        private System.Windows.Forms.Label lblBuscaSessao;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.ComboBox cmbProfissional;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace WindowsFormsApp1
{
	partial class MDuranFisioterapia
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDuranFisioterapia));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarProntuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarExcluirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarExcluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarExcluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.profissionalToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.sessãoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1482, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListarToolStripMenuItem,
            this.CadastrarToolStripMenuItem,
            this.AlterarToolStripMenuItem,
            this.gerarProntuárioToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // ListarToolStripMenuItem
            // 
            this.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem";
            this.ListarToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.ListarToolStripMenuItem.Text = "Listar";
            this.ListarToolStripMenuItem.Click += new System.EventHandler(this.ListarToolStripMenuItem_Click);
            // 
            // CadastrarToolStripMenuItem
            // 
            this.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem";
            this.CadastrarToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.CadastrarToolStripMenuItem.Text = "Cadastrar";
            this.CadastrarToolStripMenuItem.Click += new System.EventHandler(this.CadastrarToolStripMenuItem_Click);
            // 
            // AlterarToolStripMenuItem
            // 
            this.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem";
            this.AlterarToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.AlterarToolStripMenuItem.Text = "Alterar/Excluir";
            this.AlterarToolStripMenuItem.Click += new System.EventHandler(this.AlterarToolStripMenuItem_Click);
            // 
            // gerarProntuárioToolStripMenuItem
            // 
            this.gerarProntuárioToolStripMenuItem.Name = "gerarProntuárioToolStripMenuItem";
            this.gerarProntuárioToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.gerarProntuárioToolStripMenuItem.Text = "Gerar Prontuário";
            this.gerarProntuárioToolStripMenuItem.Click += new System.EventHandler(this.gerarProntuárioToolStripMenuItem_Click);
            // 
            // profissionalToolStripMenuItem
            // 
            this.profissionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem3,
            this.alterarExcluirToolStripMenuItem2});
            this.profissionalToolStripMenuItem.Name = "profissionalToolStripMenuItem";
            this.profissionalToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.profissionalToolStripMenuItem.Text = "Profissional";
            // 
            // cadastrarToolStripMenuItem3
            // 
            this.cadastrarToolStripMenuItem3.Name = "cadastrarToolStripMenuItem3";
            this.cadastrarToolStripMenuItem3.Size = new System.Drawing.Size(215, 32);
            this.cadastrarToolStripMenuItem3.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem3.Click += new System.EventHandler(this.cadastrarToolStripMenuItem3_Click);
            // 
            // alterarExcluirToolStripMenuItem2
            // 
            this.alterarExcluirToolStripMenuItem2.Name = "alterarExcluirToolStripMenuItem2";
            this.alterarExcluirToolStripMenuItem2.Size = new System.Drawing.Size(215, 32);
            this.alterarExcluirToolStripMenuItem2.Text = "Alterar/Excluir";
            this.alterarExcluirToolStripMenuItem2.Click += new System.EventHandler(this.alterarExcluirToolStripMenuItem2_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.alterarExcluirToolStripMenuItem});
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(215, 32);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // alterarExcluirToolStripMenuItem
            // 
            this.alterarExcluirToolStripMenuItem.Name = "alterarExcluirToolStripMenuItem";
            this.alterarExcluirToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.alterarExcluirToolStripMenuItem.Text = "Alterar/Excluir";
            this.alterarExcluirToolStripMenuItem.Click += new System.EventHandler(this.alterarExcluirToolStripMenuItem_Click);
            // 
            // sessãoToolStripMenuItem
            // 
            this.sessãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem2,
            this.alterarExcluirToolStripMenuItem1});
            this.sessãoToolStripMenuItem.Name = "sessãoToolStripMenuItem";
            this.sessãoToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.sessãoToolStripMenuItem.Text = "Sessão";
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(215, 32);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
            // 
            // alterarExcluirToolStripMenuItem1
            // 
            this.alterarExcluirToolStripMenuItem1.Name = "alterarExcluirToolStripMenuItem1";
            this.alterarExcluirToolStripMenuItem1.Size = new System.Drawing.Size(215, 32);
            this.alterarExcluirToolStripMenuItem1.Text = "Alterar/Excluir";
            this.alterarExcluirToolStripMenuItem1.Click += new System.EventHandler(this.alterarExcluirToolStripMenuItem1_Click);
            // 
            // MDuranFisioterapia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MDuranFisioterapia";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ListarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AlterarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerarProntuárioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem alterarExcluirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sessãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem alterarExcluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profissionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem alterarExcluirToolStripMenuItem2;
    }
}


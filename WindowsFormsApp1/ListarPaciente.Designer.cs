namespace WindowsFormsApp1
{
	partial class ListarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarPaciente));
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvPac = new System.Windows.Forms.DataGridView();
            this.txtListar = new System.Windows.Forms.TextBox();
            this.lblDescritivo = new System.Windows.Forms.Label();
            this.lblPacAbuscar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnListar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(1017, 151);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(182, 40);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvPac
            // 
            this.dgvPac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPac.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPac.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPac.Location = new System.Drawing.Point(137, 247);
            this.dgvPac.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPac.Name = "dgvPac";
            this.dgvPac.ReadOnly = true;
            this.dgvPac.Size = new System.Drawing.Size(1208, 432);
            this.dgvPac.TabIndex = 2;
            // 
            // txtListar
            // 
            this.txtListar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtListar.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListar.Location = new System.Drawing.Point(811, 157);
            this.txtListar.Margin = new System.Windows.Forms.Padding(4);
            this.txtListar.Multiline = true;
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(177, 29);
            this.txtListar.TabIndex = 3;
            // 
            // lblDescritivo
            // 
            this.lblDescritivo.AutoSize = true;
            this.lblDescritivo.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescritivo.Location = new System.Drawing.Point(488, 23);
            this.lblDescritivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescritivo.Name = "lblDescritivo";
            this.lblDescritivo.Size = new System.Drawing.Size(535, 65);
            this.lblDescritivo.TabIndex = 4;
            this.lblDescritivo.Text = "Listagem de Pacientes";
            // 
            // lblPacAbuscar
            // 
            this.lblPacAbuscar.AutoSize = true;
            this.lblPacAbuscar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacAbuscar.Location = new System.Drawing.Point(312, 157);
            this.lblPacAbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPacAbuscar.Name = "lblPacAbuscar";
            this.lblPacAbuscar.Size = new System.Drawing.Size(481, 32);
            this.lblPacAbuscar.TabIndex = 5;
            this.lblPacAbuscar.Text = "Digite o nome do Paciente que desja listar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1201, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // ListarPaciente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1444, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPacAbuscar);
            this.Controls.Add(this.lblDescritivo);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.dgvPac);
            this.Controls.Add(this.btnListar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarPaciente";
            this.Text = "ListarPaciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnListar;
		private System.Windows.Forms.DataGridView dgvPac;
		private System.Windows.Forms.TextBox txtListar;
        private System.Windows.Forms.Label lblDescritivo;
        private System.Windows.Forms.Label lblPacAbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
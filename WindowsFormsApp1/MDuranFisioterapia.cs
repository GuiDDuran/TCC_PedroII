using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class MDuranFisioterapia : Form
	{
		public MDuranFisioterapia()
		{
			InitializeComponent();
		}

		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void listarToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ListarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarPaciente listarPaciente = new ListarPaciente();
			listarPaciente.ShowDialog();
		}

		private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastrarPaciente cadastrarPaciente = new CadastrarPaciente();
			cadastrarPaciente.ShowDialog();
		}

		private void AlterarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AlterarPaciente alterar = new AlterarPaciente();
			alterar.ShowDialog();
		}

		private void gerarProntuárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GerarProntuario gerarProntuario = new GerarProntuario();
			gerarProntuario.ShowDialog();
		}

		private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CadastrarServico cadastrarServico = new CadastrarServico();
			cadastrarServico.ShowDialog();
		}

		private void alterarExcluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AlterarServico alterarServico = new AlterarServico();
			alterarServico.ShowDialog();
		}

		private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			CadastrarSessao cadastrarSessao = new CadastrarSessao();
			cadastrarSessao.ShowDialog();
		}

        private void alterarExcluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlterarSessao alterarSessao = new AlterarSessao();
            alterarSessao.ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastrarProfissional cadastrarProfissional = new CadastrarProfissional();
            cadastrarProfissional.ShowDialog();
        }

        private void alterarExcluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarProfissional alterarProfissional = new AlterarProfissional();
            alterarProfissional.ShowDialog();
        }
    }
}

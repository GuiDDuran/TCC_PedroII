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
	public partial class CadastrarPaciente : Form
	{
		public CadastrarPaciente()
		{
			InitializeComponent();
		}

		private void CadastrarPaciente_Load(object sender, EventArgs e)
		{

		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			string nome = txtNome.Text;
			string idade = txtIdade.Text;
			string cpf = txtCpf.Text;
			string endereco = txtEndereco.Text;
			string celular = txtCelular.Text;
			string email = txtEmail.Text;
			DateTime datanasc = dtpDataNasc.Value;
			string indclinica = txtIndClinica.Text;
			Paciente paciente = new Paciente(nome, idade, cpf, endereco, celular, email, datanasc, indclinica);
            BancodeDados bd = new BancodeDados();
            if (bd.conecta())
            {
                bd.adicionarPaciente(paciente);
                MessageBox.Show("Paciente adicionado com sucesso!");
                txtNome.Text = String.Empty;
                txtIdade.Text = String.Empty;
                txtCpf.Text = String.Empty;
                txtEndereco.Text = String.Empty;
                txtCelular.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtIndClinica.Text = String.Empty;
            }
            else
                MessageBox.Show("Erro ao conectar");
		}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtIdade.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtIndClinica.Text = String.Empty;
        }
    }
}

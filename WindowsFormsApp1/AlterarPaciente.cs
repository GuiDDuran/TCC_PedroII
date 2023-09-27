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
	public partial class AlterarPaciente : Form
	{
        List<Paciente> pacienteAchado = new List<Paciente>();
        public AlterarPaciente()
		{
			InitializeComponent();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            cmbBuscar.Items.Clear();
			string nome = txtBuscaPac.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            pacienteAchado = bd.buscarPaciente(nome);
            for (int i = 0; i < pacienteAchado.Count; i++)
            {
                cmbBuscar.Items.Add(pacienteAchado[i].nome);
            } 
		}

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja alterar as informações do paciente?", "Alteração", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
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
                    bd.alterarPaciente(paciente, pacienteAchado[cmbBuscar.SelectedIndex].cod_pac);
                    MessageBox.Show("Informações alteradas com sucesso!");
                }
                else
                    MessageBox.Show("Erro ao conectar");

                txtNome.Text = "";
                txtIdade.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtIndClinica.Text = "";
                txtNome.Enabled = false;
                txtIdade.Enabled = false;
                txtCpf.Enabled = false;
                txtEndereco.Enabled = false;
                txtCelular.Enabled = false;
                txtEmail.Enabled = false;
                dtpDataNasc.Enabled = false;
                txtIndClinica.Enabled = false;
                btnCancelar.Visible = false;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                AcceptButton = null;
                txtBuscaPac.Text = "";
                cmbBuscar.Text = "";
            }
        }

		private void btnExcluir_Click(object sender, EventArgs e)
		{
            DialogResult resultado = MessageBox.Show("Deseja excluir o paciente?", "Exclusão", MessageBoxButtons.YesNo);
            
            if(resultado == DialogResult.Yes)
            {
                BancodeDados bd = new BancodeDados();
                bd.conecta();
                bd.excluirPaciente(pacienteAchado[cmbBuscar.SelectedIndex].cod_pac);
                bd.excluirSessaoPaciente(pacienteAchado[cmbBuscar.SelectedIndex].cod_pac);
                MessageBox.Show("Paciente excluido!");
                Esconder();
                txtBuscaPac.Text = "";
                cmbBuscar.Text = "";
            }
        }

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Esconder();
            txtBuscaPac.Text = "";
            cmbBuscar.Text = "";
        }

        private void Esconder()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtIndClinica.Text = "";
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = false;
            btnBuscar.Visible = true;
            txtNome.Enabled = false;
            txtIdade.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            dtpDataNasc.Enabled = false;
            txtIndClinica.Enabled = false;
            txtNome.Focus();
            AcceptButton = null;
            AcceptButton = btnBuscar;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Paciente> pacienteChave = new List<Paciente>();
            string nome = txtBuscaPac.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            pacienteChave = bd.buscarPacienteChave(pacienteAchado[cmbBuscar.SelectedIndex].cod_pac);
            for (int i = 0; i < pacienteChave.Count; i++)
            {
                txtNome.Text = pacienteChave[i].nome;
                txtNome.Enabled = true;
                txtIdade.Text = pacienteChave[i].idade;
                txtIdade.Enabled = true;
                txtCpf.Text = pacienteChave[i].cpf;
                txtCpf.Enabled = true;
                txtEndereco.Text = pacienteChave[i].endereco;
                txtEndereco.Enabled = true;
                txtCelular.Text = pacienteChave[i].celular;
                txtCelular.Enabled = true;
                txtEmail.Text = pacienteChave[i].email;
                txtEmail.Enabled = true;
                dtpDataNasc.Value = pacienteChave[i].data_nasc;
                dtpDataNasc.Enabled = true;
                txtIndClinica.Text = pacienteChave[i].ind_clinica;
                txtIndClinica.Enabled = true;
                btnAlterar.Visible = true;
                btnExcluir.Visible = true;
                btnCancelar.Visible = true;


            }
        }
    }
}



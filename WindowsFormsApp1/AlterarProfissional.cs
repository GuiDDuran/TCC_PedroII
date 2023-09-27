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
    public partial class AlterarProfissional : Form
    {
        List<Profissional> profissionalAchado = new List<Profissional>();
        public AlterarProfissional()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmbBuscar.Items.Clear();
            string nome = txtBuscaProf.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            profissionalAchado = bd.buscarProfissional(nome);
            for (int i = 0; i < profissionalAchado.Count; i++)
            {
                cmbBuscar.Items.Add(profissionalAchado[i].nome);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja alterar as informações do profissional?", "Alteração", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                string nome = txtNome.Text;
                string cpf = txtCpf.Text;
                string crefito = txtCrefito.Text;
                string celular = txtCelular.Text;
                Profissional profissional = new Profissional(nome, cpf, crefito, celular);
                BancodeDados bd = new BancodeDados();
                if (bd.conecta())
                {
                    bd.alterarProfissional(profissional, profissionalAchado[cmbBuscar.SelectedIndex].cod_prof);
                    MessageBox.Show("Informações alteradas com sucesso!");
                }
                else
                    MessageBox.Show("Erro ao conectar");

                txtNome.Text = "";
                txtCpf.Text = "";
                txtCrefito.Text = "";
                txtCelular.Text = "";
                txtNome.Enabled = false;
                txtCpf.Enabled = false;
                txtCrefito.Enabled = false;
                txtCelular.Enabled = false;
                btnCancelar.Visible = false;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                AcceptButton = null;

                txtBuscaProf.Text = "";
                cmbBuscar.Text = "";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o profissional?", "Exclusão", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                BancodeDados bd = new BancodeDados();
                bd.conecta();
                bd.excluirProfissional(profissionalAchado[cmbBuscar.SelectedIndex].cod_prof);
                MessageBox.Show("Profissional excluido!");
                Esconder();
                txtBuscaProf.Text = "";
                cmbBuscar.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Esconder();
            txtBuscaProf.Text = "";
            cmbBuscar.Text = "";
        }

        private void Esconder()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCrefito.Text = "";
            txtCelular.Text = "";
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = false;
            btnBuscar.Visible = true;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtCrefito.Enabled = false;
            txtCelular.Enabled = false;
            txtNome.Focus();
            AcceptButton = null;
            AcceptButton = btnBuscar;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Profissional> profissionalChave = new List<Profissional>();
            string nome = txtBuscaProf.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            profissionalChave = bd.buscarProfissionalChave(profissionalAchado[cmbBuscar.SelectedIndex].cod_prof);
            for (int i = 0; i < profissionalChave.Count; i++)
            {
                txtNome.Text = profissionalChave[i].nome;
                txtNome.Enabled = true;
                txtCpf.Text = profissionalChave[i].cpf;
                txtCpf.Enabled = true;
                txtCrefito.Text = profissionalChave[i].crefito;
                txtCrefito.Enabled = true;
                txtCelular.Text = profissionalChave[i].celular;
                txtCelular.Enabled = true;
                btnAlterar.Visible = true;
                btnExcluir.Visible = true;
                btnCancelar.Visible = true;
            }
        }
    }
}

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
    public partial class AlterarSessao : Form
    {
        List<Paciente> pacienteAchado = new List<Paciente>();
        List<Sessao> sessaoAchada = new List<Sessao>();
        private List<Profissional> listaprofissional;
        private List<Servico> listaservico;

        public AlterarSessao()
        {
            InitializeComponent();
        }

        private void btnBuscaPac_Click(object sender, EventArgs e)
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

        private void cmbSelectSessao_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sessao> sessaoChave = new List<Sessao>();
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            sessaoChave = bd.buscarSessaoChave(sessaoAchada[cmbSelectSessao.SelectedIndex].cod_sessao);
            for (int i = 0; i < sessaoChave.Count; i++)
            {
                cmbServico.Text = bd.buscarServicoChave(sessaoChave[i].cod_serv)[0].nome;
                cmbServico.Enabled = true;
                cmbFormaPag.Text = sessaoChave[i].forma_pagamento;
                cmbFormaPag.Enabled = true;
                dtpSessao.Value = sessaoChave[i].data_sessao;
                dtpSessao.Enabled = true;
                cmbProfissional.Text = bd.buscarProfissionalChave(sessaoChave[i].cod_prof)[0].nome;
                cmbProfissional.Enabled = true;
                txtObservacao.Text = sessaoChave[i].observacao;
                txtObservacao.Enabled = true;
                btnAlterar.Visible = true;
                btnExcluir.Visible = true;
                btnCancelar.Visible = true;
            }
        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
             cmbSelectSessao.Items.Clear();
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            sessaoAchada = bd.buscarSessaoPaciente(pacienteAchado[cmbBuscar.SelectedIndex].cod_pac);
            for (int i = 0; i < sessaoAchada.Count; i++)
            {
                cmbSelectSessao.Items.Add(sessaoAchada[i].data_sessao);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja alterar as informações da sessão?", "Alteração", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                string cod_pac = pacienteAchado[cmbBuscar.SelectedIndex].cod_pac;
                string cod_serv = listaservico[cmbServico.SelectedIndex].cod_serv;
                string forma_pagamento = cmbFormaPag.Text;
                DateTime data_sessao = dtpSessao.Value;
                string cod_prof  = listaprofissional[cmbProfissional.SelectedIndex].cod_prof;
                string observacao = txtObservacao.Text;
                Sessao sessao = new Sessao(cod_pac, cod_prof, cod_serv, forma_pagamento, data_sessao, observacao);
                BancodeDados bd = new BancodeDados();
                if (bd.conecta())
                {
                    bd.alterarSessao(sessao, sessaoAchada[cmbBuscar.SelectedIndex].cod_sessao);
                    MessageBox.Show("Informações alteradas com sucesso!");
                }
                else
                    MessageBox.Show("Erro ao conectar");

                cmbServico.Text = "";
                cmbFormaPag.Text = "";
                dtpSessao.Text = "";
                cmbProfissional.Text = "";
                txtObservacao.Text = "";
                cmbServico.Enabled = false;
                cmbFormaPag.Enabled = false;
                dtpSessao.Enabled = false;
                cmbProfissional.Enabled = false;
                txtObservacao.Enabled = false;
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
            DialogResult resultado = MessageBox.Show("Deseja excluir a sessão?", "Exclusão", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                BancodeDados bd = new BancodeDados();
                bd.conecta();
                bd.excluirSessao(sessaoAchada[cmbSelectSessao.SelectedIndex].cod_sessao);
                MessageBox.Show("Sessão excluida!");
                Esconder();
                txtBuscaPac.Text = "";
                cmbBuscar.Text = "";
                cmbSelectSessao.Text = "";
            }
        }

        private void AlterarSessao_Load(object sender, EventArgs e)
        {
            BancodeDados bd = new BancodeDados();
            listaprofissional = bd.ListarProfissional();
            foreach (var profissional in listaprofissional)
            {
                cmbProfissional.Items.Add(profissional.nome);
            }

            listaservico = bd.ListarServico();
            foreach (var servico in listaservico)
            {
                cmbServico.Items.Add(servico.nome);
            }
        }

        private void Esconder()
        {
            cmbServico.Text = "";
            cmbFormaPag.Text = "";
            dtpSessao.Text = "";
            cmbProfissional.Text = "";
            txtObservacao.Text = "";
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = false;
            btnBuscaPac.Visible = true;
            cmbServico.Enabled = false;
            cmbFormaPag.Enabled = false;
            dtpSessao.Enabled = false;
            cmbProfissional.Enabled = false;
            txtObservacao.Enabled = false;
            AcceptButton = null;
            AcceptButton = btnBuscaPac;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Esconder();
            txtBuscaPac.Text = "";
            cmbBuscar.Text = "";
            cmbSelectSessao.Text = "";
        }
    }
}

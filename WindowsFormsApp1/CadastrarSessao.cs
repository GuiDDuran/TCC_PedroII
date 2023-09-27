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
    public partial class CadastrarSessao : Form
    {
        private List<Paciente> pacienteAchado;
        private List<Servico> servicoAchado;
        private List<Profissional> listaprofissional; 

        public CadastrarSessao()
        {
            InitializeComponent();
        }

        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
            string nome = txtListPac.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            pacienteAchado = bd.buscarPaciente(nome);
            DataTable dtb_Pacientes = new DataTable();
            dtb_Pacientes.Columns.Add("Nome", typeof(string));
            dtb_Pacientes.Columns.Add("Idade", typeof(string));
            dtb_Pacientes.Columns.Add("Data de Nascimento", typeof(string));
            dtb_Pacientes.Columns.Add("Indicação Clínica", typeof(string));
            for (int i = 0; i < pacienteAchado.Count; i++)
            {
                dtb_Pacientes.Rows.Add(pacienteAchado[i].nome, pacienteAchado[i].idade, pacienteAchado[i].data_nasc.ToString().Substring(0,10), pacienteAchado[i].ind_clinica);
            }
            dgvPac.DataSource = dtb_Pacientes;
        }

        private void btnBuscarServ_Click(object sender, EventArgs e)
        {
            string nome = txtListServ.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            servicoAchado = bd.buscarServico(nome);
            DataTable dtb_Servicos = new DataTable();
            //dtb_Servicos.Columns.Add("Código do Serviço", typeof(int));
            dtb_Servicos.Columns.Add("Nome", typeof(string));
            dtb_Servicos.Columns.Add("Quantidade de Sessoes", typeof(string));
            dtb_Servicos.Columns.Add("Valor", typeof(float));
            dtb_Servicos.Columns.Add("Tipo", typeof(string));
            for (int i = 0; i < servicoAchado.Count; i++)
            {
                dtb_Servicos.Rows.Add(/*servicoAchado[i].cod_serv,*/ servicoAchado[i].nome, servicoAchado[i].quantidade_de_sessoes, servicoAchado[i].valor, servicoAchado[i].tipo);
            }
            dgvServ.DataSource = dtb_Servicos;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string paciente = txtListPac.Text;
            string profissional = cmbProfissional.Text;
            string servico = txtListServ.Text;
            string forma_pag = cmbPagamento.Text;
            DateTime datasessao = dtpSessao.Value;
            string observacao = txtObservacao.Text;

            Sessao sessao = new Sessao(pacienteAchado[dgvPac.CurrentRow.Index].cod_pac.ToString(), listaprofissional[cmbProfissional.SelectedIndex].cod_prof.ToString(), servicoAchado[dgvServ.CurrentRow.Index].cod_serv.ToString(), forma_pag, datasessao, observacao);
            BancodeDados bd = new BancodeDados();
            if (bd.conecta())
            {
                bd.adicionarSessao(sessao);
                MessageBox.Show("Sessão adicionada com sucesso!");
                dgvPac.Text = String.Empty;
                txtListPac.Text = String.Empty;
                dgvServ.Text = String.Empty;
                txtListServ.Text = String.Empty;
                cmbPagamento.Text = String.Empty;
                dtpSessao.Text = String.Empty;
                cmbProfissional.Text = String.Empty;
                txtObservacao.Text = String.Empty;
            }
            else
                MessageBox.Show("Erro ao conectar");
        }

        private void dgvPac_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtListPac.Text = dgvPac.SelectedCells[0].Value.ToString();
        }

        private void dgvServ_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtListServ.Text = dgvServ.SelectedCells[0].Value.ToString();
        }

        private void CadastrarSessao_Load(object sender, EventArgs e)
        {
            BancodeDados bd = new BancodeDados();
            listaprofissional = bd.ListarProfissional();
            foreach (var profissional in listaprofissional)
            {
                cmbProfissional.Items.Add(profissional.nome);
            }
        }

        private void lblNomePac_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeServ_Click(object sender, EventArgs e)
        {

        }

        private void lblObservacao_Click(object sender, EventArgs e)
        {

        }

        private void lblPagamento_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void txtListServ_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvPac.Text = String.Empty;
            txtListPac.Text = String.Empty;
            dgvServ.Text = String.Empty;
            txtListServ.Text = String.Empty;
            cmbPagamento.Text = String.Empty;
            dtpSessao.Text = String.Empty;
            cmbProfissional.Text = String.Empty;
            txtObservacao.Text = String.Empty;
        }

        private void dgvPac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


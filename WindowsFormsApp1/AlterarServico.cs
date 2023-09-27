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
	public partial class AlterarServico : Form
	{
        List<Servico> servicoAchado = new List<Servico>();
        public AlterarServico()
		{
            InitializeComponent();
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmbBuscar.Items.Clear();
            string nome = txtBuscaServ.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            servicoAchado = bd.buscarServico(nome);
            for (int i = 0; i < servicoAchado.Count; i++)
            {
                cmbBuscar.Items.Add(servicoAchado[i].nome);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja alterar as informações do serviço?", "Alteração", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                string nome = txtNome.Text;
                string quantidade_de_sessoes = txtQntd.Text;
                string valor = txtValor.Text;
                string tipo = txtTipo.Text;
                string[] dia = new string[5];
                for (int i = 0; i < clbDia.Items.Count; i++)
                {
                    if (clbDia.GetItemChecked(i))
                        dia[i] = "sim";
                    else
                        dia[i] = "não";

                }
                Servico servico = new Servico(nome, quantidade_de_sessoes, valor, tipo, dia[0], dia[1], dia[2], dia[3], dia[4]);
                BancodeDados bd = new BancodeDados();
                if (bd.conecta())
                {
                    bd.alterarServico(servico, servicoAchado[cmbBuscar.SelectedIndex].cod_serv);
                    MessageBox.Show("Informações alteradas com sucesso!");
                }
                else
                    MessageBox.Show("Erro ao conectar");

                txtNome.Text = "";
                txtQntd.Text = "";
                txtValor.Text = "";
                txtTipo.Text = "";
                clbDia.Text = "";
                txtNome.Enabled = false;
                txtQntd.Enabled = false;
                txtValor.Enabled = false;
                txtTipo.Enabled = false;
                clbDia.Enabled = false;
                btnCancelar.Visible = false;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                AcceptButton = null;
                txtBuscaServ.Text = "";
                cmbBuscar.Text = "";
                for (int i = 0; i < 5; i++)
                    clbDia.SetItemChecked(i, false);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o serviço?", "Exclusão", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                BancodeDados bd = new BancodeDados();
                bd.conecta();
                bd.excluirServico(servicoAchado[cmbBuscar.SelectedIndex].cod_serv);
                bd.excluirSessaoServico(servicoAchado[cmbBuscar.SelectedIndex].cod_serv);
                MessageBox.Show("Serviço excluido!");
                Esconder();
                txtBuscaServ.Text = "";
                cmbBuscar.Text = "";
                for (int i = 0; i < 5; i++)
                    clbDia.SetItemChecked(i, false);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            BancodeDados bd = new BancodeDados();
            MessageBox.Show("Dados alterados com sucesso!");
            Esconder();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Esconder();
            txtBuscaServ.Text = "";
            cmbBuscar.Text = "";
            for (int i = 0; i < 5; i++)
                clbDia.SetItemChecked(i, false);
        }

        private void Esconder()
        {
            txtNome.Text = "";
            txtQntd.Text = "";
            txtValor.Text = "";
            txtTipo.Text = "";
            clbDia.Text = "";
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = false;
            btnBuscar.Visible = true;
            txtNome.Enabled = false;
            txtQntd.Enabled = false;
            txtValor.Enabled = false;
            txtTipo.Enabled = false;
            clbDia.Enabled = false;
            txtNome.Focus();
            AcceptButton = null;
            AcceptButton = btnBuscar;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbDia.Items.Count; i++)
            {
                clbDia.SetItemChecked(i, false);
            }
            List<Servico> servicoChave = new List<Servico>();
            string nome = txtBuscaServ.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            servicoChave = bd.buscarServicoChave(servicoAchado[cmbBuscar.SelectedIndex].cod_serv);
            for (int i = 0; i < servicoChave.Count; i++)
            {


                txtNome.Text = servicoChave[i].nome;
                txtNome.Enabled = true;
                txtQntd.Text = servicoChave[i].quantidade_de_sessoes;
                txtQntd.Enabled = true;
                txtValor.Text = servicoChave[i].valor;
                txtValor.Enabled = true;
                txtTipo.Text = servicoChave[i].tipo;
                txtTipo.Enabled = true;
                //clbDia.Text = servicoChave[i].dia;
                clbDia.Enabled = true;
                if (servicoChave[i].segunda == "sim")
                    clbDia.SetItemChecked(0, true);
                if (servicoChave[i].terca == "sim")
                    clbDia.SetItemChecked(1, true);
                if (servicoChave[i].quarta == "sim")
                    clbDia.SetItemChecked(2, true);
                if (servicoChave[i].quinta == "sim")
                    clbDia.SetItemChecked(3, true);
                if (servicoChave[i].sexta == "sim")
                    clbDia.SetItemChecked(4, true);

                btnAlterar.Visible = true;
                btnExcluir.Visible = true;
                btnCancelar.Visible = true;


            }
        }

        private void lblQntd_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void AlterarServico_Load(object sender, EventArgs e)
        {

        }

        private void clbDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

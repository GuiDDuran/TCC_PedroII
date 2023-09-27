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
	public partial class CadastrarServico : Form
	{
		public CadastrarServico()
		{
			InitializeComponent();
		}

		private void CadastrarServico_Load(object sender, EventArgs e)
		{

		}

        private void btnCadastrar_Click(object sender, EventArgs e)
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

            Servico servico = new Servico(nome, quantidade_de_sessoes, valor, tipo, dia[0], dia[1], dia[2], dia[3], dia[4] );
            BancodeDados bd = new BancodeDados();
            bd.adicionarServico(servico);
            if (bd.conecta())
            {
                bd.adicionarServico(servico);
                MessageBox.Show("Serviço adicionado com sucesso!");
                txtNome.Text = String.Empty;
                txtQntd.Text = String.Empty;
                txtValor.Text = String.Empty;
                txtTipo.Text = String.Empty;
                clbDia.Text = String.Empty;
                for (int i = 0; i < clbDia.Items.Count; i++)
                {
                    clbDia.SetItemChecked(i, false);
                }
            }
            else
                MessageBox.Show("Erro ao conectar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtQntd.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtTipo.Text = String.Empty;
            clbDia.Text = String.Empty;
            for (int i = 0; i < clbDia.Items.Count; i++)
            {
                clbDia.SetItemChecked(i, false);
            }
        }

        private void clbDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


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
    public partial class CadastrarProfissional : Form
    {
        public CadastrarProfissional()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string crefito = txtCrefito.Text;
            string celular = txtCelular.Text;
            Profissional profissional = new Profissional(nome, cpf, crefito, celular);
            BancodeDados bd = new BancodeDados();
            if (bd.conecta())
            {
                bd.adicionarProfissional(profissional);
                MessageBox.Show("Profissional adicionado com sucesso!");
                txtNome.Text = String.Empty;
                txtCpf.Text = String.Empty;
                txtCrefito.Text = String.Empty;
                txtCelular.Text = String.Empty;
            }
            else
                MessageBox.Show("Erro ao conectar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtCrefito.Text = String.Empty;
            txtCelular.Text = String.Empty;
        }
    }
}

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
	public partial class ListarPaciente : Form
	{
        List<Paciente> pacienteAchado = new List<Paciente>();
        public ListarPaciente()
		{
			InitializeComponent();
		}

        private void btnListar_Click(object sender, EventArgs e)
        {
            //List<Paciente> pacientes = new List<Paciente>();
            //BancodeDados bd = new BancodeDados();
            //string nome = txtListar.Text;
            //pacientes = bd.listarPaciente(nome);
            //dgvPaciente.DataSource = 

            string nome = txtListar.Text;
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            pacienteAchado = bd.buscarPaciente(nome);
            DataTable dtb_Pacientes = new DataTable();
            dtb_Pacientes.Columns.Add("Nome", typeof(string));
            dtb_Pacientes.Columns.Add("Idade", typeof(string));
            dtb_Pacientes.Columns.Add("CPF", typeof(string));
            dtb_Pacientes.Columns.Add("Endereco", typeof(string));
            dtb_Pacientes.Columns.Add("Celular", typeof(string));
            dtb_Pacientes.Columns.Add("Email", typeof(string));
            dtb_Pacientes.Columns.Add("Data de Nascimento", typeof(string));
            dtb_Pacientes.Columns.Add("Indicação Clínica", typeof(string));
            for (int i = 0; i < pacienteAchado.Count; i++)
            {
            dtb_Pacientes.Rows.Add(pacienteAchado[i].nome, pacienteAchado[i].idade, pacienteAchado[i].cpf, pacienteAchado[i].endereco, pacienteAchado[i].celular, pacienteAchado[i].email, pacienteAchado[i].data_nasc.ToString().Substring(0, 10), pacienteAchado[i].ind_clinica);
            }
            dgvPac.DataSource = dtb_Pacientes;
        }
    }
}

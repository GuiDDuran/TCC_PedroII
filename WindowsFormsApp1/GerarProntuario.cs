using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
namespace WindowsFormsApp1
{
	public partial class GerarProntuario : Form
	{
        List<Paciente> pacienteAchado = new List<Paciente>();
        public GerarProntuario()
		{
			InitializeComponent();
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void GerarProntuario_Load(object sender, EventArgs e)
        {

        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            BancodeDados bd = new BancodeDados();
            bd.conecta();
            DataTable dt = bd.busca_paciente_servico(pacienteAchado[cmbBuscar.SelectedIndex].cod_pac);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            Report report = new Report();
            report.Load("relatorio.frx");

            report.RegisterData(ds.Tables[0], "dsAtividade");
            report.GetDataSource("dsAtividade").Enabled = true;

            FastReport.DataBand dados = (FastReport.DataBand)report.FindObject("Data1");
            dados.DataSource = report.GetDataSource("dsAtividade");


            FastReport.TextObject nomeProf = (FastReport.TextObject)report.FindObject("txtNomeProf");
            FastReport.TextObject nomePac = (FastReport.TextObject)report.FindObject("NomePac");
            FastReport.TextObject nomeServ = (FastReport.TextObject)report.FindObject("txtServico");
            FastReport.TextObject pagamento = (FastReport.TextObject)report.FindObject("txtPagamento");
            FastReport.TextObject dataSessao = (FastReport.TextObject)report.FindObject("txtDataSessao");
            FastReport.TextObject obs = (FastReport.TextObject)report.FindObject("txtObservacao");
            nomeProf.Text = "[dsAtividade.nomeProf]";
            nomeServ.Text = "[dsAtividade.nomeServ]";
            pagamento.Text = "[dsAtividade.forma_pagamento]";
            dataSessao.Text = "[dsAtividade.data_sessao]";
            obs.Text = "[dsAtividade.observacao]";
            nomePac.Text = cmbBuscar.Text;

            report.Show();
        }

    }
}

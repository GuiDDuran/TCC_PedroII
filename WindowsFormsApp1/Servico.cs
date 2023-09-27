using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Servico
    {
        public string cod_serv { get; set; }
        public string nome { get; set; }
        public string quantidade_de_sessoes { get; set; }
        public string valor { get; set; }
        public string tipo { get; set; }
        public string segunda { get; set; }
        public string terca { get; set; }
        public string quarta { get; set; }
        public string quinta { get; set; }
        public string sexta { get; set; }




        public Servico(string cod_serv, string nome, string quantidade_de_sessoes, string valor, string tipo, string segunda, string terca, string quarta, string quinta, string sexta)
        {
            this.cod_serv = cod_serv;
            this.nome = nome;
            this.quantidade_de_sessoes = quantidade_de_sessoes;
            this.valor = valor;
            this.tipo = tipo;
            this.segunda = segunda;
            this.terca = terca;
            this.quarta = quarta;
            this.quinta = quinta;
            this.sexta = sexta;
        }

        public Servico(string nome, string quantidade_de_sessoes, string valor, string tipo, string segunda, string terca, string quarta, string quinta, string sexta)
        {
            this.nome = nome;
            this.quantidade_de_sessoes = quantidade_de_sessoes;
            this.valor = valor;
            this.tipo = tipo;
            this.segunda = segunda;
            this.terca = terca;
            this.quarta = quarta;
            this.quinta = quinta;
            this.sexta = sexta;
        }
    }
}

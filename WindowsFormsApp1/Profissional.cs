using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Profissional
    {
        public string cod_prof { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string crefito { get; set; }
        public string celular { get; set; }

        public Profissional(string cod_prof, string nome, string cpf, string crefito, string celular)
        {
            this.cod_prof = cod_prof;
            this.nome = nome;
            this.cpf = cpf;
            this.crefito = crefito;
            this.celular = celular;
        }

        public Profissional(string nome, string cpf, string crefito, string celular)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.crefito = crefito;
            this.celular = celular;
        }
    }
}

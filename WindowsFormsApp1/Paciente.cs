using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Paciente
	{
        public string cod_pac { get; set; }
        public string nome { get; set; }
		public string idade { get; set; }
		public string cpf { get; set; }
		public string endereco { get; set; }
		public string celular { get; set; }
		public string email { get; set; }
		public DateTime data_nasc { get; set; }
		public string ind_clinica { get; set; }

		public Paciente(string nome, string idade, string cpf, string endereco, string celular, string email, DateTime data_nasc, string ind_clinica)
		{
			this.nome = nome;
			this.idade = idade;
			this.cpf = cpf;
			this.endereco = endereco;
			this.celular = celular;
			this.email= email;
			this.data_nasc = data_nasc;
			this.ind_clinica = ind_clinica;
		}
        public Paciente(string _cod_pac, string nome, string idade, string cpf, string endereco, string celular, string email, DateTime data_nasc, string ind_clinica)
        {
            this.cod_pac = _cod_pac;
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.endereco = endereco;
            this.celular = celular;
            this.email = email;
            this.data_nasc = data_nasc;
            this.ind_clinica = ind_clinica;
        }
    }
}

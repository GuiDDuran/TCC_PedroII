using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class BancodeDados
    {
        MySqlConnection bdConn;



        public bool conecta()
        {
            bool retorno = true;
            bdConn = new MySqlConnection("server=localhost;database=bd_fisioterapia;uid=root;pwd=''");
            try
            {
                bdConn.Open();
            }
            catch
            {
                retorno = false;
            }
            return retorno;

        }

        public void desconecta()
        {
            bdConn.Close();
        }

        public void adicionarPaciente(Paciente paciente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into paciente(nome,idade, cpf, endereco, celular, email, data_nasc, ind_clinica) values (@nome, @idade, @cpf, @endereco, @celular, @email, @data_nasc, @ind_clinica) ", bdConn);
                cmd.Parameters.AddWithValue("@nome", paciente.nome);
                cmd.Parameters.AddWithValue("@idade", paciente.idade);
                cmd.Parameters.AddWithValue("@cpf", paciente.cpf);
                cmd.Parameters.AddWithValue("@endereco", paciente.endereco);
                cmd.Parameters.AddWithValue("@celular", paciente.celular);
                cmd.Parameters.AddWithValue("@email", paciente.email);
                cmd.Parameters.AddWithValue("@data_nasc", paciente.data_nasc);
                cmd.Parameters.AddWithValue("@ind_clinica", paciente.ind_clinica);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw new InsercaoException("Erro sw Inserção");
            }
        }

            public void adicionarProfissional(Profissional profissional)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("insert into profissional(nome, cpf, crefito, celular) values (@nome, @cpf, @crefito, @celular) ", bdConn);
                    cmd.Parameters.AddWithValue("@nome", profissional.nome);
                    cmd.Parameters.AddWithValue("@cpf", profissional.cpf);
                    cmd.Parameters.AddWithValue("@crefito", profissional.crefito);
                    cmd.Parameters.AddWithValue("@celular", profissional.celular);

                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //throw new InsercaoException("Erro sw Inserção");
                }

            }

        
        public void adicionarServico(Servico servico)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into servico(nome, quantidade_de_sessoes, valor, tipo, segunda, terca, quarta, quinta, sexta) values (@nome, @quantidade_de_sessoes, @valor, @tipo, @segunda, @terca, @quarta, @quinta, @sexta) ", bdConn);
                cmd.Parameters.AddWithValue("@nome", servico.nome);
                cmd.Parameters.AddWithValue("@quantidade_de_sessoes", servico.quantidade_de_sessoes);
                cmd.Parameters.AddWithValue("@valor", servico.valor);
                cmd.Parameters.AddWithValue("@tipo", servico.tipo);
                cmd.Parameters.AddWithValue("@segunda", servico.segunda);
                cmd.Parameters.AddWithValue("@terca", servico.terca);
                cmd.Parameters.AddWithValue("@quarta", servico.quarta);
                cmd.Parameters.AddWithValue("@quinta", servico.quinta);
                cmd.Parameters.AddWithValue("@sexta", servico.sexta);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw new InsercaoException("Erro sw Inserção");
            }

        }

        
        public void adicionarSessao(Sessao sessao)
        {
            //try
            {
                MySqlCommand cmd = new MySqlCommand("insert into sessao(cod_pac, cod_prof, cod_serv, forma_pagamento, data_sessao, observacao) values (@cod_pac, @cod_prof, @cod_serv, @forma_pagamento, @data_sessao, @observacao) ", bdConn);
                cmd.Parameters.AddWithValue("@cod_pac", sessao.cod_pac);
                cmd.Parameters.AddWithValue("@cod_prof", sessao.cod_prof);
                cmd.Parameters.AddWithValue("@cod_serv", sessao.cod_serv);
                cmd.Parameters.AddWithValue("@forma_pagamento", sessao.forma_pagamento);
                cmd.Parameters.AddWithValue("@data_sessao", sessao.data_sessao);
                cmd.Parameters.AddWithValue("@observacao", sessao.observacao);

                cmd.ExecuteNonQuery();
            }
            //catch
            {
                //throw new InsercaoException("Erro sw Inserção");
            }
        }
        

        public List<Paciente> buscarPaciente(string texto)
        {
            List<Paciente> pacientes = new List<Paciente>();
            string cod_pac, nome, idade, cpf, endereco, celular, email, ind_clinica;
            DateTime data_nasc;
            MySqlCommand cmd = new MySqlCommand("Select * from paciente where nome like '" + texto + "%'", bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_pac = reader["cod_pac"].ToString();
                nome = reader["nome"].ToString();
                idade = reader["idade"].ToString();
                cpf = reader["cpf"].ToString();
                endereco = reader["endereco"].ToString();
                celular = reader["celular"].ToString();
                email = reader["email"].ToString();
                data_nasc = Convert.ToDateTime(reader["data_nasc"]);
                ind_clinica = reader["ind_clinica"].ToString();
                Paciente paciente = new Paciente(cod_pac, nome, idade, cpf, endereco, celular, email, data_nasc, ind_clinica);
                pacientes.Add(paciente);
            }
            reader.Close();
            return pacientes;
        }

        public List<Paciente> buscarPacienteChave(string texto)
        {
            List<Paciente> pacientes = new List<Paciente>();
            string cod_pac, nome, idade, cpf, endereco, celular, email, ind_clinica;
            DateTime data_nasc;
            MySqlCommand cmd = new MySqlCommand("Select * from paciente where cod_pac = " + texto, bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_pac = reader["cod_pac"].ToString();
                nome = reader["nome"].ToString();
                idade = reader["idade"].ToString();
                cpf = reader["cpf"].ToString();
                endereco = reader["endereco"].ToString();
                celular = reader["celular"].ToString();
                email = reader["email"].ToString();
                data_nasc = Convert.ToDateTime(reader["data_nasc"]);
                ind_clinica = reader["ind_clinica"].ToString();
                Paciente paciente = new Paciente(cod_pac, nome, idade, cpf, endereco, celular, email, data_nasc, ind_clinica);
                pacientes.Add(paciente);
            }
            reader.Close();
            return pacientes;
        }

        public List<Profissional> ListarProfissional()
        {
            conecta();
            List<Profissional> profissionais = new List<Profissional>();
            string cod_prof, nome, cpf, crefito, celular;
            MySqlCommand cmd = new MySqlCommand("Select * from profissional", bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_prof = reader["cod_prof"].ToString();
                nome = reader["nome"].ToString();
                cpf = reader["cpf"].ToString();
                crefito = reader["crefito"].ToString();
                celular = reader["celular"].ToString();
                Profissional profissional = new Profissional(cod_prof, nome, cpf, crefito, celular);
                profissionais.Add(profissional);
            }
            reader.Close();
            return profissionais;
        }

        public List<Servico> ListarServico()
        {
            conecta();
            List<Servico> servicos = new List<Servico>();
            string cod_serv, nome, quantidade_de_sessoes, valor, tipo, segunda, terca, quarta, quinta, sexta;
            MySqlCommand cmd = new MySqlCommand("Select * from servico", bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_serv = reader["cod_serv"].ToString();
                nome = reader["nome"].ToString();
                quantidade_de_sessoes = reader["quantidade_de_sessoes"].ToString();
                valor = reader["valor"].ToString();
                tipo = reader["tipo"].ToString();
                segunda = reader["segunda"].ToString();
                terca = reader["terca"].ToString();
                quarta = reader["quarta"].ToString();
                quinta = reader["quinta"].ToString();
                sexta = reader["sexta"].ToString();
                Servico servico = new Servico(cod_serv, nome, quantidade_de_sessoes, valor, tipo, segunda, terca, quarta, quinta, sexta);
                servicos.Add(servico);
            }
            reader.Close();
            return servicos;
        }

        public List<Profissional> buscarProfissional(string texto)
        {
            conecta();
            List<Profissional> profissionais = new List<Profissional>();
            string cod_prof, nome, cpf, crefito, celular;
            MySqlCommand cmd = new MySqlCommand("Select * from profissional where nome like '" + texto + "%'", bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_prof = reader["cod_prof"].ToString();
                nome = reader["nome"].ToString();
                cpf = reader["cpf"].ToString();
                crefito = reader["crefito"].ToString();
                celular = reader["celular"].ToString();
                Profissional profissional = new Profissional(cod_prof, nome,cpf, crefito, celular);
                profissionais.Add(profissional);
            }
            reader.Close();
            return profissionais;
        }

        public List<Profissional> buscarProfissionalChave(string texto)
        {
            List<Profissional> profissionais = new List<Profissional>();
            string cod_prof, nome, cpf, crefito, celular;
            MySqlCommand cmd = new MySqlCommand("Select * from profissional where cod_prof = " + texto, bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_prof = reader["cod_prof"].ToString();
                nome = reader["nome"].ToString();
                cpf = reader["cpf"].ToString();
                crefito = reader["crefito"].ToString();
                celular = reader["celular"].ToString();
                Profissional profissional = new Profissional(cod_prof, nome, cpf, crefito, celular);
                profissionais.Add(profissional);
            }
            reader.Close();
            return profissionais;
        }

        public List<Servico> buscarServico(string texto)
        {
            List<Servico> servicos = new List<Servico>();
            string cod_serv, nome, quantidade_de_sessoes, valor, tipo, segunda, terca, quarta, quinta, sexta;
            MySqlCommand cmd = new MySqlCommand("Select * from servico where nome like '" + texto + "%'", bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_serv = reader["cod_serv"].ToString();
                nome = reader["nome"].ToString();
                quantidade_de_sessoes = reader["quantidade_de_sessoes"].ToString();
                valor = reader["valor"].ToString();
                tipo = reader["tipo"].ToString();
                segunda = reader["segunda"].ToString();
                terca = reader["terca"].ToString();
                quarta = reader["quarta"].ToString();
                quinta = reader["quinta"].ToString();
                sexta = reader["sexta"].ToString();
                Servico servico = new Servico(cod_serv, nome, quantidade_de_sessoes, valor, tipo, segunda, terca, quarta, quinta, sexta);
                servicos.Add(servico);
            }
            reader.Close();
            return servicos;
        }

        public List<Servico> buscarServicoChave(string texto)
        {
            List<Servico> servicos = new List<Servico>();
            string cod_serv, nome, quantidade_de_sessoes, valor, tipo, segunda, terca, quarta, quinta, sexta;
            MySqlCommand cmd = new MySqlCommand("Select * from servico where cod_serv = " + texto, bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_serv = reader["cod_serv"].ToString();
                nome = reader["nome"].ToString();
                quantidade_de_sessoes = reader["quantidade_de_sessoes"].ToString();
                valor = reader["valor"].ToString();
                tipo = reader["tipo"].ToString();
                segunda = reader["segunda"].ToString();
                terca = reader["terca"].ToString();
                quarta = reader["quarta"].ToString();
                quinta = reader["quinta"].ToString();
                sexta = reader["sexta"].ToString();
                Servico servico = new Servico(cod_serv, nome, quantidade_de_sessoes, valor, tipo, segunda, terca, quarta, quinta, sexta);
                servicos.Add(servico);
            }
            reader.Close();
            return servicos;
        }

        public List<Sessao> buscarSessao(string texto)
        {
            List<Sessao> sessoes = new List<Sessao>();
            string cod_pac, cod_prof, cod_serv, forma_pagamento, observacao;
            DateTime data_sessao;
            MySqlCommand cmd = new MySqlCommand("Select * from sessao where nome like '" + texto + "%'", bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_pac = reader["cod_pac"].ToString();
                cod_prof = reader["cod_prof"].ToString();
                cod_serv = reader["cod_serv"].ToString();
                forma_pagamento = reader["forma_pagamento"].ToString();
                data_sessao = Convert.ToDateTime(reader["data_sessao"].ToString());
                observacao = reader["observacao"].ToString();
                Sessao sessao = new Sessao(cod_pac, cod_prof, cod_serv, forma_pagamento, data_sessao, observacao);
                sessoes.Add(sessao);
            }
            reader.Close();
            return sessoes;
        }

        public List<Sessao> buscarSessaoChave(string texto)
        {
            List<Sessao> sessoes = new List<Sessao>();
            string cod_sessao, cod_pac, cod_prof, cod_serv, forma_pagamento, observacao;
            DateTime data_sessao;
            MySqlCommand cmd = new MySqlCommand("Select * from sessao where cod_sessao = " + texto, bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_sessao = reader["cod_sessao"].ToString();
                cod_pac = reader["cod_pac"].ToString();
                cod_prof = reader["cod_prof"].ToString();
                cod_serv = reader["cod_serv"].ToString();
                forma_pagamento = reader["forma_pagamento"].ToString();
                data_sessao = Convert.ToDateTime(reader["data_sessao"]);
                observacao = reader["observacao"].ToString();
                Sessao sessao = new Sessao(cod_pac, cod_prof, cod_serv, forma_pagamento, data_sessao, observacao);
                sessao.cod_sessao = cod_sessao;
                sessoes.Add(sessao);
            }
            reader.Close();
            return sessoes;
        }

        public List<Sessao> buscarSessaoPaciente(string texto)
        {
            List<Sessao> sessoes = new List<Sessao>();
            string cod_sessao, cod_pac, cod_prof, cod_serv, forma_pagamento, observacao;
            DateTime data_sessao;
            MySqlCommand cmd = new MySqlCommand("Select * from sessao where cod_pac = " + texto, bdConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod_sessao = reader["cod_sessao"].ToString();
                cod_pac = reader["cod_pac"].ToString();
                cod_prof = reader["cod_prof"].ToString();
                cod_serv = reader["cod_serv"].ToString();
                forma_pagamento = reader["forma_pagamento"].ToString();
                data_sessao = Convert.ToDateTime(reader["data_sessao"]);
                observacao = reader["observacao"].ToString();
                Sessao sessao = new Sessao(cod_pac, cod_prof, cod_serv, forma_pagamento, data_sessao, observacao);
                sessao.cod_sessao = cod_sessao;
                sessoes.Add(sessao);
            }
            reader.Close();
            return sessoes;
        }

        public void alterarPaciente(Paciente paciente, string cod_pac)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update paciente set nome = @nome ,idade = @idade, cpf = @cpf, endereco = @endereco, celular = @celular, email = @email, data_nasc = @data_nasc, ind_clinica = @ind_clinica WHERE cod_pac = '" + cod_pac + "'", bdConn);
                cmd.Parameters.AddWithValue("@nome", paciente.nome);
                cmd.Parameters.AddWithValue("@idade", paciente.idade);
                cmd.Parameters.AddWithValue("@cpf", paciente.cpf);
                cmd.Parameters.AddWithValue("@endereco", paciente.endereco);
                cmd.Parameters.AddWithValue("@celular", paciente.celular);
                cmd.Parameters.AddWithValue("@email", paciente.email);
                cmd.Parameters.AddWithValue("@data_nasc", paciente.data_nasc);
                cmd.Parameters.AddWithValue("@ind_clinica", paciente.ind_clinica);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw new InsercaoException("Erro sw Inserção");
            }

        }

        public void alterarProfissional(Profissional profissional, string cod_prof)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update profissional set nome = @nome , cpf = @cpf, crefito = @crefito, celular = @celular WHERE cod_prof = '" + cod_prof + "'", bdConn);
                cmd.Parameters.AddWithValue("@nome", profissional.nome);
                cmd.Parameters.AddWithValue("@cpf", profissional.cpf);
                cmd.Parameters.AddWithValue("@crefito", profissional.crefito);
                cmd.Parameters.AddWithValue("@celular", profissional.celular);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw new InsercaoException("Erro sw Inserção");
            }

        }

        public void alterarServico(Servico servico, string cod_serv)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update servico set nome = @nome, quantidade_de_sessoes = @quantidade_de_sessoes, valor = @valor, tipo = @tipo, segunda = @segunda, terca = @terca, quarta = @quarta, quinta = @quinta, sexta = @sexta WHERE cod_serv = '" + cod_serv + "'", bdConn);
                cmd.Parameters.AddWithValue("@nome", servico.nome);
                cmd.Parameters.AddWithValue("@quantidade_de_sessoes", servico.quantidade_de_sessoes);
                cmd.Parameters.AddWithValue("@valor", servico.valor);
                cmd.Parameters.AddWithValue("@tipo", servico.tipo);
                cmd.Parameters.AddWithValue("@segunda", servico.segunda);
                cmd.Parameters.AddWithValue("@terca", servico.terca);
                cmd.Parameters.AddWithValue("@quarta", servico.quarta);
                cmd.Parameters.AddWithValue("@quinta", servico.quinta);
                cmd.Parameters.AddWithValue("@sexta", servico.sexta);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw new InsercaoException("Erro sw Inserção");
            }
        }

        public void alterarSessao(Sessao sessao, string cod_sessao)
        {
           // try
            {
                MySqlCommand cmd = new MySqlCommand("update sessao set cod_serv = @servico, forma_pagamento = @forma_pagamento, data_sessao = @data_sessao, cod_prof = @profissional, observacao = @observacao WHERE cod_sessao = '" + cod_sessao + "'", bdConn);
                cmd.Parameters.AddWithValue("@servico", sessao.cod_serv);
                cmd.Parameters.AddWithValue("@forma_pagamento", sessao.forma_pagamento);
                cmd.Parameters.AddWithValue("@data_sessao", sessao.data_sessao);
                cmd.Parameters.AddWithValue("@profissional", sessao.cod_prof);
                cmd.Parameters.AddWithValue("@observacao", sessao.observacao);
                cmd.ExecuteNonQuery();
            }
           // catch
            {
                //throw new InsercaoException("Erro sw Inserção");
            }
        }

        public void excluirPaciente(string cod_pac)
        {
            MySqlCommand cmd = new MySqlCommand("delete from paciente WHERE cod_pac = '" + cod_pac + "'", bdConn);
            cmd.ExecuteNonQuery();
        }

        public void excluirProfissional(string cod_prof)
        {
            MySqlCommand cmd = new MySqlCommand("delete from profissional WHERE cod_prof = '" + cod_prof + "'", bdConn);
            cmd.ExecuteNonQuery();
        }

        public void excluirServico(string cod_serv)
        {
            MySqlCommand cmd = new MySqlCommand("delete from servico WHERE cod_serv = '" + cod_serv + "'", bdConn);
            cmd.ExecuteNonQuery();
        }

        public void excluirSessao(string cod_sessao)
        {
            MySqlCommand cmd = new MySqlCommand("delete from sessao WHERE cod_sessao = '" + cod_sessao + "'", bdConn);
            cmd.ExecuteNonQuery();
        }
        public void excluirSessaoServico(string cod_serv)
        {
            MySqlCommand cmd = new MySqlCommand("delete from sessao WHERE cod_serv = '" + cod_serv + "'", bdConn);
            cmd.ExecuteNonQuery();
        }
        public void excluirSessaoPaciente(string cod_pac)
        {
            MySqlCommand cmd = new MySqlCommand("delete from sessao WHERE cod_pac = '" + cod_pac + "'", bdConn);
            cmd.ExecuteNonQuery();
        }
        public DataTable busca_paciente_servico(string cod_pac)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT B.nome as nomeServ, C.nome as nomeProf, forma_pagamento, data_sessao, observacao FROM sessao A, servico B, profissional C where A.cod_pac = " + cod_pac + " and A.cod_serv = B.cod_serv and A.cod_prof = C.cod_prof order by data_sessao", bdConn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(dt);
            //dt = ds.Tables[0];
            return dt;
        }
    }
}


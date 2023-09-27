using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Sessao
    {
        public string cod_sessao { get; set; }
        public string cod_pac { get; set; }
        public string cod_prof { get; set; }
        public string cod_serv { get; set; }
        public string forma_pagamento { get; set; }
        public DateTime data_sessao { get; set; }
        public string observacao { get; set; }

        public Sessao(string cod_pac, string cod_prof, string cod_serv, string forma_pagamento, DateTime data_sessao, string observacao)
        {
            this.cod_pac = cod_pac;
            this.cod_prof = cod_prof;
            this.cod_serv = cod_serv;
            this.forma_pagamento = forma_pagamento;
            this. data_sessao = data_sessao;
            this.observacao = observacao;
        }

        public Sessao(string forma_pagamento, DateTime sessao, string observacao)
        {
            this.forma_pagamento = forma_pagamento;
            this.data_sessao = data_sessao;
            this.observacao = observacao;
        }
    }
}

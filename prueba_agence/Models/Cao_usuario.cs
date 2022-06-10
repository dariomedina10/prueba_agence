using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba_agence.Models
{
    public class Cao_usuario

    {

        public string co_usuario { get; set; }

        public string no_usuario { get; set; }
        public string ds_senha { get; set; }
        public string co_usuario_autorizacao { get; set; }
        public string nu_matricula { get; set; }
        public DateTime dt_nascimento { get; set; }
        public DateTime dt_admissao_empresa { get; set; }
        public DateTime dt_desligamento { get; set; }
        public DateTime dt_inclusao { get; set; }
        public DateTime dt_expiracao { get; set; }
        public DateTime dt_alteracao { get; set; }

        public string ds_endereco { get; set; }

        public string co_no_email { get; set; }
        public string no_email_pessoal { get; set; }
        public string msn { get; set; }


    }
}
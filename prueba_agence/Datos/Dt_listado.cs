using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using prueba_agence.Models;
using System.Configuration;
using System.Data.Common;

namespace prueba_agence.Datos
{
    //List<Cao_usuario> objLista = new List<Cao_usuario>();

    public class Dt_listado
    {

        public List<Cao_usuario> Retornarusuario()
        {
            List<Cao_usuario> objLista = new List<Cao_usuario>();

            //Data Source=;Initial Catalog= ; User ID= ; Password=
            using (SqlConnection oconexion = new SqlConnection("Data Source=(local); Initial Catalog=Agence Integrated Security=True"))
            {
                string query = "listado_consultores";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new Cao_usuario()
                        {
                            co_usuario = dr["co_usuario"].ToString(),
                            no_usuario = dr["no_usuario"].ToString(),
                            ds_senha = dr["ds_senha"].ToString(),
                            co_usuario_autorizacao = dr["co_usuario_autorizacao"].ToString(),
                            nu_matricula = dr["nu_matricula"].ToString(),
                           dt_nascimento = Convert.ToDateTime(dr["dt_nascimento"].ToString()),
                            dt_admissao_empresa = Convert.ToDateTime(dr["dt_admissao_empresa"].ToString()),
                            dt_desligamento = Convert.ToDateTime(dr["dt_desligamento"].ToString()),
                            dt_inclusao = Convert.ToDateTime(dr["dt_inclusao"].ToString()),
                            dt_expiracao = Convert.ToDateTime(dr["dt_expiracao "].ToString()),
                            dt_alteracao = Convert.ToDateTime(dr["dt_alteracao "].ToString()),
                            ds_endereco = dr["ds_endereco"].ToString(),
                            co_no_email = dr["co_no_email"].ToString(),
                            no_email_pessoal = dr["no_email_pessoal"].ToString(),
                            msn = dr["msn"].ToString(),
                           
                        });
                    }
                }



            }


            return objLista;

        }
    }
}

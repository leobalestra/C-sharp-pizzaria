using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaAlianca.DAL
{
    class LoginDaoComandos
    {
        public string mensagem = "";
        public bool conexao = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool VerificarLogin(string login, string senha)
        {
            //procurar no bd
            cmd.CommandText = "select * from tblFuncionario where dsc_login = @login and dsc_senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    conexao = true;
                }
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return conexao;
        }

        public int CalcularQtdPizzasHoje()
        {
            int qtd = 0;
            cmd.CommandText = "select count(*) qtd from tblPedido where CONVERT (date, dta_pedido) = CONVERT (date, getdate()) and sta_pedido <> 'C'";
            cmd.Connection = con.Conectar();
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //PAREI AQUI NÃO ESTA FUNCIONANDO
                    qtd = Convert.ToInt32(dr[0]);
                }
            }
            catch (Exception)
            {
                this.mensagem = "Erro no banco";
            }
            return qtd;
        }
    }
}

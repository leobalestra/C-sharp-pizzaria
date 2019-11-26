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
            cmd.CommandText = "select COUNT(*) qtd from tblPedido where CONVERT (date, dta_pedido) = CONVERT (date, getdate()) and sta_pedido <> 'C'";
            cmd.Connection = con.Conectar();
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (Convert.ToInt32(dr[0]) > 0)
                    qtd = Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
            return qtd;
        }

        public List<string> PesquisarCliente(int nmrTelefone)
        {
            List<string> cliente = new List<string>();

            cmd.CommandText = "SELECT c.id_cliente, c.nme_cliente, c.nmr_telefone1, c.nmr_telefone2, c.nmr_cep, c.dsc_rua, c.nmr_endereco, coalesce(cast((select MAX(Convert(varchar(10), dta_pedido, 103)) from tblPedido p where p.id_cliente = c.id_cliente ) as varchar(30)), 'Não houve') dta_ultimo_pedido FROM tblCliente c WHERE c.nmr_telefone1 = @nmrTelefone OR c.nmr_telefone2 = @nmrTelefone";
            cmd.Parameters.AddWithValue("@nmrTelefone", nmrTelefone);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cliente.Add(dr[0].ToString());
                    cliente.Add(dr[1].ToString());
                    cliente.Add(dr[2].ToString());
                    cliente.Add(dr[3].ToString());
                    cliente.Add(dr[4].ToString());
                    cliente.Add(dr[5].ToString());
                    cliente.Add(dr[6].ToString());
                    cliente.Add(dr[7].ToString());
                }
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
            return cliente;
        }

        public String PesquisarNomeProduto(int idProduto)
        {
            String produto = "";
            cmd.CommandText = "SELECT dsc_produto FROM tblProduto WHERE id_produto = @idProduto";
            cmd.Parameters.AddWithValue("@idProduto", idProduto);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    produto = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }

            return produto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaAlianca.DAL
{
    class LoginDaoComandos
    {
        public string mensagem = "";
        public bool conexao = false;

        public bool VerificarLogin(string login, string senha)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

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

        internal List<string> CarregarPizzasEntregues()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            List<string> pizzas = new List<string>();

            cmd.CommandText = "SELECT convert(varchar, p.dta_pedido, 8)+' - '+cast(c.nme_cliente as varchar)+' - '+cast(c.nmr_telefone1 as varchar)+' - ('+cast(p.id_pedido as varchar)+')' FROM tblPedido p INNER JOIN tblCliente c ON c.id_cliente = p.id_cliente WHERE p.sta_pedido IN ( 'D', 'C' ) order by 1 desc";
            cmd.Connection = con.Conectar();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pizzas.Add(dr[0].ToString());
            }
            return pizzas;
        }

        internal List<string> CarregarPizzasAndamento()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            List<string> pizzas = new List<string>();

            cmd.CommandText = "SELECT convert(varchar, p.dta_pedido, 8)+' - '+cast(c.nme_cliente as varchar)+' - '+cast(c.nmr_telefone1 as varchar)+' - ('+cast(p.id_pedido as varchar)+')' FROM tblPedido p INNER JOIN tblCliente c ON c.id_cliente = p.id_cliente WHERE p.sta_pedido = 'E' order by 1 desc";
            cmd.Connection = con.Conectar();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pizzas.Add(dr[0].ToString());
            }
            return pizzas;
        }

        public int CalcularQtdPizzasHoje()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

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

        internal bool FinalizarPedido(int cdgPedido)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE tblPedido set dta_despacho = getdate(), sta_pedido = 'D' where id_pedido = @idpedido";
            cmd.Parameters.AddWithValue("@idpedido", cdgPedido);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool InserirPedido(int idCliente, int comanda, string loginAtual, string tpoPagamento, decimal vlrTroco)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO tblPedido VALUES (@idcliente, @idcomanda, (SELECT id_funcionario FROM tblFuncionario WHERE dsc_login = @idatendente), 'E', getdate(), null, @tpoPagamento, @vlrtroco)";
            cmd.Parameters.AddWithValue("@idcliente", idCliente);
            cmd.Parameters.AddWithValue("@idcomanda", comanda);
            cmd.Parameters.AddWithValue("@idatendente", loginAtual);
            cmd.Parameters.AddWithValue("@tpoPagamento", tpoPagamento);
            cmd.Parameters.AddWithValue("@vlrtroco", vlrTroco);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal int MontarComanda(List<string> comanda)
        {
            Conexao con = new Conexao();
            int qtdLista = comanda.Count;
            string produto;
            int idProduto, idcomanda;

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "select max(id_comanda)+1 from tblComanda";
            cmd.Connection = con.Conectar();
            dr = cmd.ExecuteReader();
            dr.Read();
            idcomanda = Convert.ToInt32(dr[0]);
            dr.Close();
            cmd.Dispose();

            for (int i = 0; i < qtdLista; i++)
            {
                SqlCommand cmdd = new SqlCommand();
                produto = comanda[i];
                idProduto = Convert.ToInt32(produto.Substring(0, produto.IndexOf('-') - 1));
                cmdd.CommandText = "INSERT INTO tblComanda VALUES (@idcomanda, @idproduto, CASE WHEN (select tpo_produto from tblProduto where id_produto = @idproduto) IN ('D', 'P') THEN 0.5 ELSE 1.0 END)";
                cmdd.Parameters.AddWithValue("@idproduto", idProduto);
                cmdd.Parameters.AddWithValue("@idcomanda", idcomanda);
                cmdd.Connection = con.Conectar();
                cmdd.ExecuteNonQuery();
                cmdd.Dispose();
            }
            return idcomanda;
        }

        internal double ValorTotalPedido(ListBox lstPedido)
        {
            Conexao con = new Conexao();

            double valorTotal = 0;
            int qtdLista = lstPedido.Items.Count;
            int idProduto;
            string produto;

            for (int i = 0; i < qtdLista; i++)
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                produto = lstPedido.GetItemText(lstPedido.Items[i]);
                idProduto = Convert.ToInt32(produto.Substring(0, produto.IndexOf('-')-1));
                
                cmd.CommandText = "select ( case when tpo_produto in ('P', 'D') then 0.5 else 1 end ) * vlr_produto from tblProduto where id_produto = @idProduto";
                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                valorTotal = valorTotal + Convert.ToInt32(dr[0]);


                dr.Close(); 
                cmd.Dispose();                
            }
            return valorTotal;
        }

        public List<string> PesquisarCliente(long nmrTelefone)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

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
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

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

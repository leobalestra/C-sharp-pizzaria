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

        #region Pedido

        internal List<string> CarregarPizzasEntregues()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            List<string> pizzas = new List<string>();

            cmd.CommandText = "SELECT top (6) case when p.sta_pedido = 'C' then 'Cancelado' else 'Despachado' end+' ás '+convert(varchar, p.dta_despacho, 8)+' | '+cast(c.nme_cliente as varchar)+' | Tel.: '+cast(c.nmr_telefone1 as varchar)+' - (cód. '+cast(p.id_pedido as varchar)+')' FROM tblPedido p INNER JOIN tblCliente c ON c.id_cliente = p.id_cliente WHERE p.sta_pedido IN ( 'D', 'C' ) order by dta_despacho desc";
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

            cmd.CommandText = "SELECT convert(varchar, p.dta_pedido, 8)+' | '+cast(c.nme_cliente as varchar)+' | Tel.: '+cast(c.nmr_telefone1 as varchar)+' - (cód. '+cast(p.id_pedido as varchar)+')' FROM tblPedido p INNER JOIN tblCliente c ON c.id_cliente = p.id_cliente WHERE p.sta_pedido = 'E' order by 1 desc";
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

        internal bool CancelarPedido(int cdgPedido)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE tblPedido set dta_despacho = getdate(), sta_pedido = 'C' where id_pedido = @idpedido";
            cmd.Parameters.AddWithValue("@idpedido", cdgPedido);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
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

        #endregion

        #region Profissonal

        internal bool EditarProfissional(decimal id, string login, string nome, string funcao, string loginAlt, string senha, char situacao)
        {
            char funcaoChar;

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (funcao == "Admin")
                funcaoChar = 'A';
            else if (funcao == "Atendente")
                funcaoChar = 'T';
            else if (funcao == "Gerente")
                funcaoChar = 'G';
            else if (funcao == "Pizzaiolo")
                funcaoChar = 'P';
            else
                funcaoChar = 'E';

            cmd.CommandText = "UPDATE tblFuncionario set sta_funcionario = @situacao, dsc_login = @login, mme_funcionario = @profissional, tpo_funcao = @funcao, dta_alteracao = getdate(), dsc_login_alterou = @loginAlt, dsc_senha = @senha where id_funcionario = @idprofissional";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@profissional", nome);
            cmd.Parameters.AddWithValue("@funcao", funcaoChar);
            cmd.Parameters.AddWithValue("@idprofissional", id);
            cmd.Parameters.AddWithValue("@loginAlt", loginAlt.ToUpper());
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@situacao", situacao);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool InativarProfissional(int id, string loginalt)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE tblFuncionario set sta_funcionario = 'I', dta_alteracao = getdate(), dsc_login_alterou = @loginAlt where id_funcionario = @idprofissional";
            cmd.Parameters.AddWithValue("@idprofissional", id);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool CriarProfissional(string login, string nome, string funcao, string loginAtual, string senha, char situacao)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            
            char funcaoChar;
            if (funcao == "Admin")
                funcaoChar = 'A';
            else if (funcao == "Atendente")
                funcaoChar = 'T';
            else if (funcao == "Gerente")
                funcaoChar = 'G';
            else if (funcao == "Pizzaiolo")
                funcaoChar = 'P';
            else
                funcaoChar = 'E';

            cmd.CommandText = "INSERT INTO tblFuncionario VALUES (@login, @nome, @funcao, getdate(), @logincad, @senha, null, null, @situacao);";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@funcao", funcaoChar);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@situacao", situacao);
            cmd.Parameters.AddWithValue("@logincad", loginAtual.ToUpper());
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal int IdLogin(string login)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

            int id = 0;
            cmd.CommandText = "SELECT id_funcionario FROM tblFuncionario WHERE dsc_login = @login";
            cmd.Parameters.AddWithValue("@login", login);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = Convert.ToInt32(dr[0]);
                }
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }

            return id;
        }

        #endregion

        #region Cliente

        internal bool EditarCliente(int id, string nome, long telefone1, long? telefone2, string cep, int numero, string endereco, string loginAtual)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            if (telefone2 != null)
            {
                cmd.CommandText = "UPDATE tblCliente SET nme_cliente = @nomecliente, nmr_telefone1 = @telefone1, nmr_telefone2 = @telefone2, nmr_cep = @cep, dsc_rua = @endereco, nmr_endereco = @numero, dta_cadastro = getdate(), dsc_login_cadastro = @loginAlt where id_cliente = @id";
                cmd.Parameters.AddWithValue("@telefone2", telefone2);
            }
                
            else
                cmd.CommandText = "UPDATE tblCliente SET nme_cliente = @nomecliente, nmr_telefone1 = @telefone1, nmr_telefone2 = null, nmr_cep = @cep, dsc_rua = @endereco, nmr_endereco = @numero, dta_cadastro = getdate(), dsc_login_cadastro = @loginAlt where id_cliente = @id";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nomecliente", nome);
            cmd.Parameters.AddWithValue("@telefone1", telefone1);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@loginAlt", loginAtual.ToUpper());
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool CriarCliente(int id, string nome, long telefone1, long? telefone2, string cep, int numero, string endereco, string loginAtual)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            if(telefone2 != null)
            {
                cmd.CommandText = "INSERT INTO tblCliente VALUES (@nomecliente, @telefone1, @telefone2, @cep, @endereco, @numero, getdate(), @loginAlt)";
                cmd.Parameters.AddWithValue("@telefone2", telefone2);
            }
            else
                cmd.CommandText = "INSERT INTO tblCliente (nme_cliente, nmr_telefone1, nmr_cep, dsc_rua, nmr_endereco, dta_cadastro, dsc_login_cadastro) VALUES (@nomecliente, @telefone1, @cep, @endereco, @numero, getdate(), @loginAlt)";
            
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nomecliente", nome);
            cmd.Parameters.AddWithValue("@telefone1", telefone1);            
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@loginAlt", loginAtual.ToUpper());
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool ExcluirCliente(int id)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM tblCliente WHERE id_cliente = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool VerificarClientePedido(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

            int qtd = 0;
            cmd.CommandText = "select COUNT(*) qtd from tblPedido where id_cliente = @id";
            cmd.Parameters.AddWithValue("@id", id);
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
            return (qtd == 0 ? false : true);
        }

        internal int VerificarTelefone(long tel1, long? tel2)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;

            int id = 0;
            if(tel2 == null)
                cmd.CommandText = "SELECT id_cliente FROM tblCliente  where nmr_telefone1 = @telefone1";
            else
            {
                cmd.CommandText = "SELECT id_cliente FROM tblCliente  where ( nmr_telefone1 = @telefone1 OR nmr_telefone2 = @telefone2 )";
                cmd.Parameters.AddWithValue("@telefone2", tel2);
            }
            cmd.Parameters.AddWithValue("@telefone1", tel1);
            cmd.Connection = con.Conectar();
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (Convert.ToInt32(dr[0]) > 0)
                    id = Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
            return id;
        }


        #endregion

        #region Produtos

        internal bool EditarProduto(decimal id, string nome, decimal valor, char tipo, char situacao)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE tblProduto set tpo_produto = @tipo, dsc_produto = @nome, vlr_produto = @valor, sta_produto = @situacao where id_produto = @id";
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@situacao", situacao);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool CriarProduto(decimal id, string nome, decimal valor, char tipo, char situacao)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO tblProduto VALUES (@tipo, @nome, @valor, @situacao)";
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@situacao", situacao);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        internal bool InativarProduto(int id)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE tblProduto SET sta_produto = 'F' where id_produto = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return true;
        }

        #endregion

    }
}

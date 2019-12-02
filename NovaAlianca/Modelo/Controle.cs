using NovaAlianca.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaAlianca.Modelo
{
    public class Controle
    {
        public bool acesso;
        public string mensagemConexao = "";

        public bool Acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            acesso = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagemConexao = loginDao.mensagem;
            }
            return acesso;
        }

        public int QtdPizzasHoje()
        {
            LoginDaoComandos qtd = new LoginDaoComandos();
            return qtd.CalcularQtdPizzasHoje();
        }

        internal List<string> PizzasEntregues()
        {
            LoginDaoComandos pizzas = new LoginDaoComandos();
            return pizzas.CarregarPizzasEntregues();
        }

        public List<string> PizzasEmAndamento()
        {
            LoginDaoComandos pizzas = new LoginDaoComandos();
            return pizzas.CarregarPizzasAndamento();
        }

        public List<string> PesquisaCliente(long nmrTelefone)
        {
            LoginDaoComandos cliente = new LoginDaoComandos();
            return cliente.PesquisarCliente(nmrTelefone);
        }

        public string NomeProduto(int idProduto)
        {
            LoginDaoComandos produto = new LoginDaoComandos();
            return produto.PesquisarNomeProduto(idProduto);
        }

        public double ValorPedido(ListBox lstPedido)
        {
            LoginDaoComandos valorTotal = new LoginDaoComandos();
            return valorTotal.ValorTotalPedido(lstPedido);
        }

        public int MontarComanda(List<string> comanda)
        {
            LoginDaoComandos idcomanda = new LoginDaoComandos();
            return idcomanda.MontarComanda(comanda);
        }

        public bool InserirPedido(int idCliente, int comanda, string loginAtual, string tpoPagamento, decimal vlrTroco)
        {
            LoginDaoComandos idpedido = new LoginDaoComandos();
            return idpedido.InserirPedido(idCliente, comanda, loginAtual, tpoPagamento, vlrTroco);
        }

        public bool FinalizarPedido(int cdgPedido)
        {
            LoginDaoComandos idpedido = new LoginDaoComandos();
            return idpedido.FinalizarPedido(cdgPedido);
        }
    }
}

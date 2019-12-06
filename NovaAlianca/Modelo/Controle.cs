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

        internal List<string> ResumoPedido(int cdgPedido)
        {
            LoginDaoComandos resumoPedido = new LoginDaoComandos();
            return resumoPedido.ResumirPedido(cdgPedido);
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

        internal bool CancelarPedido(int cdgPedido)
        {
            LoginDaoComandos idpedido = new LoginDaoComandos();
            return idpedido.CancelarPedido(cdgPedido);
        }

        internal bool EditarProfissional(decimal id, string login, string nome, string funcao, string senha, char situacao)
        {
            LoginDaoComandos profissional = new LoginDaoComandos();
            return profissional.EditarProfissional(id, login, nome, funcao, Login._loginAtual, senha, situacao);
        }

        internal bool CriarProfissional(string login, string nome, string funcao, string senha, char situacao)
        {
            LoginDaoComandos profissional = new LoginDaoComandos();
            return profissional.CriarProfissional(login, nome, funcao, Login._loginAtual, senha, situacao);
        }

        internal int IddoLogin(string login)
        {
            LoginDaoComandos idlogin = new LoginDaoComandos();
            return idlogin.IdLogin(login);
        }

        internal void InativarProfissional(int id)
        {
            LoginDaoComandos inativar = new LoginDaoComandos();
            inativar.InativarProfissional(id, Login._loginAtual);
        }

        internal bool EditarCliente(int id, string nome, long telefone1, long? telefone2, string cep, int numero, string endereco)
        {
            LoginDaoComandos editar = new LoginDaoComandos();
            return editar.EditarCliente(id, nome, telefone1, telefone2, cep, numero, endereco, Login._loginAtual);
        }

        internal bool CriarCliente(int id, string nome, long telefone1, long? telefone2, string cep, int numero, string endereco)
        {
            LoginDaoComandos criar = new LoginDaoComandos();
            return criar.CriarCliente(id, nome, telefone1, telefone2, cep, numero, endereco, Login._loginAtual);
        }

        internal bool ExcluirCliente(int id)
        {
            LoginDaoComandos excluir = new LoginDaoComandos();
            return excluir.ExcluirCliente(id);
        }

        internal bool VerificarClientePedido(int id)
        {
            LoginDaoComandos pedidoCliente = new LoginDaoComandos();
            return pedidoCliente.VerificarClientePedido(id);
        }

        internal int VerificarTelefone(long tel1, long? tel2)
        {
            LoginDaoComandos verificartelefones = new LoginDaoComandos();
            return verificartelefones.VerificarTelefone(tel1, tel2);
        }

        internal bool InativarProduto(int id)
        {
            LoginDaoComandos inativar = new LoginDaoComandos();
            return inativar.InativarProduto(id);
        }

        internal bool EditarProduto(decimal id, string nomme, decimal valor, char tipo, char situacao)
        {
            LoginDaoComandos editar = new LoginDaoComandos();
            return editar.EditarProduto(id, nomme, valor, tipo, situacao);
        }

        internal bool CriarProduto(decimal id, string nomme, decimal valor, char tipo, char situacao)
        {
            LoginDaoComandos criar = new LoginDaoComandos();
            return criar.CriarProduto(id, nomme, valor, tipo, situacao);
        }
    }
}

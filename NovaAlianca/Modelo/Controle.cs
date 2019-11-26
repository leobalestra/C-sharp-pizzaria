using NovaAlianca.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<string> PesquisaCliente(int nmrTelefone)
        {
            LoginDaoComandos cliente = new LoginDaoComandos();
            return cliente.PesquisarCliente(nmrTelefone);
        }

        public string NomeProduto(int idProduto)
        {
            LoginDaoComandos produto = new LoginDaoComandos();
            return produto.PesquisarNomeProduto(idProduto);
        }
    }
}

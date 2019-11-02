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
    }
}

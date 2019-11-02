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
        public string mensagem = "";

        public bool Acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            acesso = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return acesso;
        }

        public string Cadastrar(string login, string senha, string confSenha)
        {
            return mensagem;
        }
    }
}

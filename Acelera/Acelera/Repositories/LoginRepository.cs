using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera.Models;

namespace Acelera.Repositories
{
    public static class LoginRepository
    {
        public static List<Login> logins = new List<Login>();

        public static void Cadastrar(string email, string senha)
        {
            int novoId = logins.Count;
            Login novoLogin = new Login(novoId, email, senha);
            logins.Add(novoLogin);
        }

        public static Login Autenticar(string email, string senha)
        {
            foreach (var login in logins)
            {
                if (login.Email == email && login.Senha == senha)
                    return login;
            }
            return null;
        }

        public static List<Login> ListarTodos()
        {
            return logins;
        }
    }

}

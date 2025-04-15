using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Models;

namespace Acelera.Repositories
{
    public static class LoginRepository
    {
        public static List<Login> logins = new List<Login>();

        public static bool Cadastrar(string email, string senha)
        {
            bool existe = logins.Any(login => login.Email == email);

            if (existe)
            {
                return false;
            }

            int novoId = logins.Count;
            Login novoLogin = new Login(novoId, email, senha);
            logins.Add(novoLogin);

            return true;
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
        public static bool RedefinirSenha(string email, string novaSenha)
        {
            var login = logins.FirstOrDefault(l => l.Email == email);

            if (login != null)
            {
                login.Senha = novaSenha;
                return true;
            }

            return false; // e-mail não encontrado
        }
    }

}

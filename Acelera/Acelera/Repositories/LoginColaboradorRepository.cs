using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera.Models;

namespace Acelera.Repositories
{
    public static class LoginColaboradorRepository
    {
        public static List<Login> logins = new List<Login>();

        private static int? usuarioLogadoId;

        public static bool Cadastrar(string email, string senha)
        {
            bool existe = logins.Any(login => login.Email == email);

            if (existe)
            {
                return false;
            }

            int Id = logins.Count;
            Login novoLogin = new Login(Id, email, senha);
            logins.Add(novoLogin);

            return true;
        }

        public static Login Autenticar(string email, string senha)
        {
            foreach (var login in logins)
            {
                if (login.Email == email && login.Senha == senha)
                {

                    usuarioLogadoId = login.Id;
                    return login;
                }
            }
            return null;
        }

        // Método para verificar se um usuário está logado
        public static bool UsuarioEstaLogado()
        {
            return usuarioLogadoId.HasValue; // Retorna true se estiver logado, false caso contrário
        }

        // Método para obter o ID do usuário logado
        public static int? GetUsuarioLogadoId()
        {
            return usuarioLogadoId;
        }

        // Método para deslogar o usuário (limpar o ID)
        public static void Sair()
        {
            usuarioLogadoId = null;
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

            return false;
        }
    }
}

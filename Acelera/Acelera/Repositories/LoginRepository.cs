using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera.Models;
using QRCoder;

namespace Acelera.Repositories
{
    public static class LoginRepository
    {
        public static List<Login> logins = new List<Login>();

        private static int? usuarioLogadoId;

        private static int lastIdGenerated = 0;

        public static int generateId()
        {
            return lastIdGenerated ++;
        }
        public static bool Cadastrar(string email, string senha)
        {
            bool existe = logins.Any(login => login.Email == email);

            if (existe)
                return false;

            int Id = generateId();
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

        public static bool UsuarioEstaLogado()
        {
            return usuarioLogadoId.HasValue; 
        }

        public static int? GetUsuarioLogadoId()
        {
            return usuarioLogadoId;
        }

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

        public static bool ExcluirConta(int id)
        {
            var login = logins.FirstOrDefault(l => l.Id == id);
            if (login != null)
            {
                logins.Remove(login);
                return true;
            }
            return false;
        }
    }
}

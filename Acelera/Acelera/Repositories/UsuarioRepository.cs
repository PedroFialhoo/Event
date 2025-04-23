using System;
using System.Collections.Generic;
using Acelera.Models;

namespace Acelera.Repositories
{
    public static class UsuarioRepository
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public static bool SalvarUsuario(Usuario usuario)
        {
            // Verifica se o usuário com o mesmo id já existe
            var usuarioExistente = usuarios.Find(u => u.Id == usuario.Id);
            if (usuarioExistente != null)
            {
                return false; // Usuário com o mesmo ID já existe
            }

            usuarios.Add(usuario);
            return true;
        }

        public static Usuario ObterUsuarioPorId(int id)
        {
            return usuarios.Find(u => u.Id == id);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }
    }
}

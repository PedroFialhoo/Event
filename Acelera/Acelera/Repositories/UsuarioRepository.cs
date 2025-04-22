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

        // Método para encontrar um usuário pelo ID
        public static Usuario ObterUsuarioPorId(int id)
        {
            return usuarios.Find(u => u.Id == id);
        }

        // Método para listar todos os usuários (para fins de debug ou consulta)
        public static List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }
    }
}

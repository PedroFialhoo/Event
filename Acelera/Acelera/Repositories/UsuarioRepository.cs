using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        public static bool RemoverUsuario(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
                return true;
            }
            return false;
        }
        public static bool AtualizarUsuario(int id, Usuario usuarioAtualizado)
        {
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuarioExistente != null)
            {
                if (!string.IsNullOrEmpty(usuarioAtualizado.Nome))
                    usuarioExistente.Nome= usuarioAtualizado.Nome;

                if (usuarioAtualizado.DataNascimento != default(DateTime))
                    usuarioExistente.DataNascimento = usuarioAtualizado.DataNascimento;

                if (!string.IsNullOrEmpty(usuarioAtualizado.Telefone))
                    usuarioExistente.Telefone = usuarioAtualizado.Telefone;

                if (!string.IsNullOrEmpty(usuarioAtualizado.Cpf))
                    usuarioExistente.Cpf = usuarioAtualizado.Cpf;

                if (!string.IsNullOrEmpty(usuarioAtualizado.Cidade))
                    usuarioExistente.Cidade = usuarioAtualizado.Cidade;

                if (!string.IsNullOrEmpty(usuarioAtualizado.Estado))
                    usuarioExistente.Estado = usuarioAtualizado.Estado;

                if (usuarioAtualizado.Imagem != null)
                    usuarioExistente.Imagem = usuarioAtualizado.Imagem;

                return true;
            }

            return false;
        }

        
    }
}

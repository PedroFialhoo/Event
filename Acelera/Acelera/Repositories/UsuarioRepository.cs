using Acelera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera.Repositories
{
    class UsuarioRepository
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void Adicionar(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public List<Usuario> Listar()
        {
            return usuarios;
        }
    }
}

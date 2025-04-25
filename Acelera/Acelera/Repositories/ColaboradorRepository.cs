using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera.Models;

namespace Acelera.Repositories
{
    public static class ColaboradorRepository
    {
        public static List<Colaborador> colaboradores = new List<Colaborador>();

        public static int? idLogado;

        public static bool CadastrarColaborador(Colaborador novoColaborador)
        {
            var usuarioExistente = colaboradores.Find(c => c.Id == novoColaborador.Id);
            if (usuarioExistente != null)
            {
                return false; // Usuário com o mesmo ID já existe
            }

            colaboradores.Add(novoColaborador);
            return true;
        }

        public static Colaborador ObterColaboradorPorId(int id)
        {
            return colaboradores.Find(c => c.Id == id);
        }
        public static string ObterNomeColaboradorPorId(int id)
        {
            var colaborador = colaboradores.Find(c => c.Id == id);
            return colaborador != null ? colaborador.Nome : null;
        }

    }
}

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
        
        public static bool AtualizarColaborador(int id, Colaborador colaboradorAtualizado)
        {
            var colaboradorExistente = colaboradores.FirstOrDefault(u => u.Id == id);

            if (colaboradorExistente != null)
            {
                if (!string.IsNullOrEmpty(colaboradorAtualizado.Nome))
                    colaboradorExistente.Nome = colaboradorAtualizado.Nome;

                if (!string.IsNullOrEmpty(colaboradorAtualizado.Telefone))
                    colaboradorExistente.Telefone = colaboradorAtualizado.Telefone;

                if (!string.IsNullOrEmpty(colaboradorAtualizado.Cnpj))
                    colaboradorExistente.Cnpj = colaboradorAtualizado.Cnpj;

                if (!string.IsNullOrEmpty(colaboradorAtualizado.NomeEmpresa))
                    colaboradorExistente.NomeEmpresa = colaboradorAtualizado.NomeEmpresa;

                if (colaboradorAtualizado.Imagem != null)
                    colaboradorExistente.Imagem = colaboradorAtualizado.Imagem;

                return true;
            }

            return false;
        }
    }

}


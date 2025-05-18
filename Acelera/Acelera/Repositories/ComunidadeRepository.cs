using Acelera.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acelera.Repositories
{
    public class ComunidadeRepository
    {
        private List<Comunidade> comunidades = new List<Comunidade>();

        public Comunidade ObterOuCriarPorCategoria(string categoria)
        {
            var comunidade = comunidades.FirstOrDefault(c =>
                c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase));

            if (comunidade == null)
            {
                comunidade = new Comunidade { Categoria = categoria };
                comunidades.Add(comunidade);
            }

            return comunidade;
        }

        public bool AdicionarParticipante(string categoria, string usuario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (!comunidade.Participantes.Contains(usuario))
            {
                comunidade.Participantes.Add(usuario);
                return true;
            }
            return false;
        }
        public bool SairDaComunidade(string categoria, string usuario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (comunidade.Participantes.Contains(usuario))
            {
                comunidade.Participantes.Remove(usuario);
                return true;
            }
            return false;
        }
        public List<string> ListarParticipantes(string categoria)
        {
            var comunidade = comunidades.FirstOrDefault(c =>
                c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase));

            return comunidade?.Participantes ?? new List<string>();
        }
        public bool AdicionarPublicacao(string categoria, Publicacao publicacao)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            comunidade.Publicacoes.Add(publicacao);
            return true;
        }

        public bool ComentarPublicacao(string categoria, int indexPublicacao, Comentario comentario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (comunidade.Publicacoes.Count > indexPublicacao)
            {
                comunidade.Publicacoes[indexPublicacao].Comentarios.Add(comentario);
                return true;
            }
            return false;
        }

        public bool CurtirPublicacao(string categoria, int indexPublicacao, string usuario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (comunidade.Publicacoes.Count > indexPublicacao)
            {
                var pub = comunidade.Publicacoes[indexPublicacao];
                if (!pub.Curtidas.Contains(usuario))
                {
                    pub.Curtidas.Add(usuario);
                    return true;
                }
            }
            return false;
        }

        public List<Publicacao> ListarPublicacoes(string categoria)
        {
            var comunidade = comunidades.FirstOrDefault(c =>
                c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase));

            return comunidade?.Publicacoes ?? new List<Publicacao>();
        }
    }
}


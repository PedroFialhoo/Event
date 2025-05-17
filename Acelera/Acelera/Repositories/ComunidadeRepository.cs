using Acelera.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acelera.Repositories
{
    public class ComunidadeRepository
    {
        private List<Comunidade> comunidades = new List<Comunidade>();
        private int proximoId = 1;

        public void Criar(Comunidade comunidade, string responsavel, string categoria)
        {
            comunidade.Id = proximoId++;
            comunidade.Responsavel = responsavel;
            comunidade.Participantes = new List<string> { responsavel };
            comunidade.Publicacoes = new List<Publicacao>();
            comunidade.Categoria = categoria; 
            comunidades.Add(comunidade);
        }

        public Comunidade ObterPorCategoria(string categoria, string nome)
        {
            return comunidades.FirstOrDefault(c =>
                c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase) &&
                c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public List<Comunidade> ListarTodas()
        {
            return comunidades;
        }

        public List<Comunidade> ListarPorCategoria(string categoria)
        {
            return comunidades.Where(c => c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool Editar(string categoria, string nome, string responsavel, Comunidade atualizada)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null && comunidade.Responsavel == responsavel)
            {
                comunidade.Nome = atualizada.Nome;
                comunidade.Categoria = atualizada.Categoria;
                comunidade.Descricao = atualizada.Descricao;
                comunidade.Foto = atualizada.Foto;
                return true;
            }
            return false; 
        }


        public bool Excluir(string categoria, string nome, string responsavel)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null && comunidade.Responsavel == responsavel)
            {
                comunidades.Remove(comunidade);
                return true;
            }
            return false; 
        }


        public bool AdicionarParticipante(string categoria, string nome, string usuario)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null && !comunidade.Participantes.Contains(usuario))
            {
                comunidade.Participantes.Add(usuario);
                return true;
            }
            return false;
        }

        public bool SairDaComunidade(string categoria, string nome, string usuario)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null && comunidade.Participantes.Contains(usuario))
            {
                comunidade.Participantes.Remove(usuario);
                return true;
            }
            return false; 
        }


        public bool RemoverParticipante(string categoria, string nome, string responsavel, string usuarioParaRemover)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null && comunidade.Responsavel == responsavel)
            {
                if (usuarioParaRemover != responsavel && comunidade.Participantes.Contains(usuarioParaRemover))
                {
                    comunidade.Participantes.Remove(usuarioParaRemover);
                    return true;
                }
            }
            return false; 
        }


        public List<string> ListarParticipantes(string categoria, string nome)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null)
            {
                var listaOrdenada = new List<string> { comunidade.Responsavel }; 
                listaOrdenada.AddRange(comunidade.Participantes.Where(p => p != comunidade.Responsavel)); 
                return listaOrdenada;
            }
            return new List<string>();
        }


        public bool AdicionarPublicacao(string categoria, string nome, Publicacao publicacao)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null)
            {
                comunidade.Publicacoes.Add(publicacao);
                return true;
            }
            return false;
        }
        public bool ExcluirPublicacao(string categoria, string nome, int Id)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            if (comunidade != null)
            {
                var publicacao = comunidade.Publicacoes.FirstOrDefault(p => p.Id == Id);
                if (publicacao != null)
                {
                    comunidade.Publicacoes.Remove(publicacao);
                    return true;
                }
            }
            return false; 
        }

        public List<Publicacao> ListarPublicacoes(string categoria, string nome)
        {
            var comunidade = ObterPorCategoria(categoria, nome);
            return comunidade?.Publicacoes ?? new List<Publicacao>();
        }
    }
}


using Acelera.Models;
using Acelera.Repositories;
using System;
using System.Collections.Generic;

namespace Acelera.Controllers
{
    public class ComunidadeController
    {
        private readonly ComunidadeRepository comunidadeRepo = new ComunidadeRepository();

        public bool EntrarNaComunidade(string categoria, string usuario)
        {
            try
            {
                return comunidadeRepo.AdicionarParticipante(categoria, usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao entrar na comunidade: {ex.Message}");
                return false;
            }
        }

        public bool SairDaComunidade(string categoria, string usuario)
        {
            try
            {
                return comunidadeRepo.SairDaComunidade(categoria, usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao sair da comunidade: {ex.Message}");
                return false;
            }
        }

        public List<string> ListarParticipantes(string categoria)
        {
            try
            {
                return comunidadeRepo.ListarParticipantes(categoria);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar participantes: {ex.Message}");
                return new List<string>();
            }
        }

        public bool CriarPublicacao(string categoria, Publicacao publicacao)
        {
            try
            {
                comunidadeRepo.AdicionarPublicacao(categoria, publicacao);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar publicação: {ex.Message}");
                return false;
            }
        }

        public List<Publicacao> ListarPublicacoes(string categoria)
        {
            try
            {
                return comunidadeRepo.ListarPublicacoes(categoria);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar publicações: {ex.Message}");
                return new List<Publicacao>();
            }
        }

        public bool CurtirPublicacao(string categoria, int indice, string usuario)
        {
            try
            {
                return comunidadeRepo.CurtirPublicacao(categoria, indice, usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao curtir publicação: {ex.Message}");
                return false;
            }
        }

        public bool ComentarPublicacao(string categoria, int indice, Comentario comentario)
        {
            try
            {
                comunidadeRepo.ComentarPublicacao(categoria, indice, comentario);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao comentar publicação: {ex.Message}");
                return false;
            }
        }
    }
}


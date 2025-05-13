using Acelera.Models;
using Acelera.Repositories;
using System;
using System.Collections.Generic;

namespace Acelera.Controllers
{
    public class EventoController
    {
        private readonly ComunidadeRepository comunidadeRepo = new ComunidadeRepository();

        public bool CriarComunidade(Comunidade comunidade, string responsavel, string categoria)
        {
            try
            {
                comunidadeRepo.Criar(comunidade, responsavel, categoria);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar comunidade: {ex.Message}");
                return false;
            }
        }
        public bool EditarComunidade(string categoria, string nome, string responsavel, Comunidade atualizada)
        {
            try
            {
                return comunidadeRepo.Editar(categoria, nome, responsavel, atualizada);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar comunidade: {ex.Message}");
                return false;
            }
        }
        public bool ExcluirComunidade(string categoria, string nome, string responsavel)
        {
            try
            {
                return comunidadeRepo.Excluir(categoria, nome, responsavel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir comunidade: {ex.Message}");
                return false;
            }
        }
        public bool RemoverParticipante(string categoria, string nome, string responsavel, string usuarioParaRemover)
        {
            try
            {
                return comunidadeRepo.RemoverParticipante(categoria, nome, responsavel, usuarioParaRemover);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover participante: {ex.Message}");
                return false;
            }
        }
        public bool EntrarNaComunidade(string categoria, string nome, string usuario)
        {
            try
            {
                return comunidadeRepo.AdicionarParticipante(categoria, nome, usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao entrar na comunidade: {ex.Message}");
                return false;
            }
        }
        public bool SairDaComunidade(string categoria, string nome, string usuario)
        {
            try
            {
                return comunidadeRepo.SairDaComunidade(categoria, nome, usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao sair da comunidade: {ex.Message}");
                return false;
            }
        }
        public List<string> ListarParticipantes(string categoria, string nome)
        {
            try
            {
                return comunidadeRepo.ListarParticipantes(categoria, nome);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar participantes: {ex.Message}");
                return new List<string>();
            }
        }

        public bool CriarPublicacao(string categoria, string nome, Publicacao publicacao)
        {
            try
            {
                return comunidadeRepo.AdicionarPublicacao(categoria, nome, publicacao);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar publicação: {ex.Message}");
                return false;
            }
        }
        public List<Publicacao> ListarPublicacoes(string categoria, string nome)
        {
            try
            {
                return comunidadeRepo.ListarPublicacoes(categoria, nome);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar publicações: {ex.Message}");
                return new List<Publicacao>();
            }
        }
        public bool ExcluirPublicacao(string categoria, string nome, int idPublicacao)
        {
            try
            {
                return comunidadeRepo.ExcluirPublicacao(categoria, nome, idPublicacao);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir publicação: {ex.Message}");
                return false;
            }
        }
    }
}

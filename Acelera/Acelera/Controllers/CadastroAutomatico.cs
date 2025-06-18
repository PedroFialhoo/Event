using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera.Models;
using Acelera.Repositories;

namespace Acelera.Controllers
{
    public class CadastroAutomatico
    {
        public static void Executar()
        {
            string email = "pedro@gmail.com";
            string senha = "pedro@gmail.com";

            LoginRepository.Cadastrar(email, senha);

            string email2 = "pedro@gmail.com";
            string senha2 = "pedro@gmail.com";
            string cnpj = "1";

            LoginColaboradorRepository.Cadastrar(email2, senha2, cnpj);

            Usuario usuario = new Usuario
            {
                Id = 0,
                Nome = "Pedro",
                Telefone = "11999999999",
                Cpf = "467.262.218-51",
                Estado = "SP"
            };

            UsuarioRepository.SalvarUsuario(usuario);

            Colaborador colaborador = new Colaborador
            {
                Id = 0,
                Nome = "Pedro Colaborador",
                Telefone = "11999999999",
            };

            ColaboradorRepository.CadastrarColaborador(colaborador);
            List<Eventos> listaEventos = new List<Eventos>
{
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Workshop de Programação", Colaborador = "Pedro Colaborador", Descricao = "Evento sobre C#", Tipo = "Tecnologia", Estado = "SP" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Feira de Ciências", Colaborador = "Pedro Colaborador", Descricao = "Experimentos escolares", Tipo = "Educação" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Oficina de Artes", Colaborador = "Pedro Colaborador", Descricao = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Hackathon 2025", Colaborador = "Pedro Colaborador", Descricao = "Maratona de programação", Tipo = "Tecnologia" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Show de Talentos", Colaborador = "Pedro Colaborador", Descricao = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Palestra sobre Sustentabilidade", Colaborador = "Pedro Colaborador", Descricao = "Ecologia e meio ambiente", Tipo = "Educação" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Curso de Fotografia", Colaborador = "Pedro Colaborador", Descricao = "Aprenda a fotografar melhor", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Seminário de História", Colaborador = "Pedro Colaborador", Descricao = "Fatos históricos e debates", Tipo = "Educação" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Conferência de Tecnologia", Colaborador = "Pedro Colaborador", Descricao = "Inovações e startups", Tipo = "Tecnologia" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Aula de Dança", Colaborador = "Pedro Colaborador", Descricao = "Ritmos diversos", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Exposição de Pinturas", Colaborador = "Pedro Colaborador", Descricao = "Obras de artistas locais", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Curso de Inglês Intensivo", Colaborador = "Pedro Colaborador", Descricao = "Aulas práticas", Tipo = "Educação" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Campeonato de Xadrez", Colaborador = "Pedro Colaborador", Descricao = "Competição aberta", Tipo = "Esporte" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Encontro Literário", Colaborador = "Pedro Colaborador", Descricao = "Autores e leitores reunidos", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Feira do Livro", Colaborador = "Pedro Colaborador", Descricao = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Debate Filosófico", Colaborador = "Pedro Colaborador", Descricao = "Discussões reflexivas", Tipo = "Educação" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Cinema ao Ar Livre", Colaborador = "Pedro Colaborador", Descricao = "Filmes para todos", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Oficina de Robótica", Colaborador = "Pedro Colaborador", Descricao = "Montagem de robôs", Tipo = "Tecnologia" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Feira Gastronômica", Colaborador = "Pedro Colaborador", Descricao = "Comidas do mundo", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Corrida de Rua", Colaborador = "Pedro Colaborador", Descricao = "Atividade esportiva", Tipo = "Esporte" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Workshop de Escrita Criativa", Colaborador = "Pedro Colaborador", Descricao = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Encontro de Gamers", Colaborador = "Pedro Colaborador", Descricao = "Jogos e campeonatos", Tipo = "Tecnologia" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Curso de Jardinagem", Colaborador = "Pedro Colaborador", Descricao = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Festival de Música", Colaborador = "Pedro Colaborador", Descricao = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Oficina de Teatro", Colaborador = "Pedro Colaborador", Descricao = "Técnicas de atuação", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Sessão de Meditação", Colaborador = "Pedro Colaborador", Descricao = "Prática guiada", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Palestra de Finanças Pessoais", Colaborador = "Pedro Colaborador", Descricao = "Organize seu dinheiro", Tipo = "Educação" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Mostra de Curtas", Colaborador = "Pedro Colaborador", Descricao = "Curtas-metragens independentes", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Aula de Yoga", Colaborador = "Pedro Colaborador", Descricao = "Relaxamento e flexibilidade", Tipo = "Outros" },
    new Eventos { Id = EventoRepository.generateId(), NomeEvento = "Torneio de Vôlei", Colaborador = "Pedro Colaborador", Descricao = "Equipes amadoras", Tipo = "Esportes" }
};

            // Cadastra todos os eventos
            foreach (var evento in listaEventos)
            {
                EventoRepository.CadastrarEvento(evento);
            }

        }
    }
}

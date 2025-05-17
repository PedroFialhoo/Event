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
            };

            UsuarioRepository.SalvarUsuario(usuario);

            Colaborador colaborador = new Colaborador
            {
                Id = 0,
                Nome = "Pedro Colaborador",
                Telefone = "11999999999",
            };

            ColaboradorRepository.CadastrarColaborador(colaborador);

            Eventos eventos = new Eventos
            {
                Id = EventoRepository.generateId(),
                NomeEvento = "Primeiro Evento",
                Colaborador = "Pedro Colaborador",
                Descricao = "Descrição do evento",
                Tipo = "Educação"

            };
            Eventos eventos1 = new Eventos
            {
                Id = EventoRepository.generateId(),
                NomeEvento = "Segundo Evento",
                Colaborador = "Pedro Colaborador",
                Descricao = "Descrição do evento"

            };
            Eventos eventos2 = new Eventos
            {
                Id = EventoRepository.generateId(),
                NomeEvento = "Champions",
                Colaborador = "Pedro Colaborador",
                Descricao = "Descrição do evento",
                Tipo = "Educação"

            };
            Eventos eventos3 = new Eventos
            {
                Id = EventoRepository.generateId(),
                NomeEvento = "Musical",
                Colaborador = "Pedro Colaborador",
                Descricao = "Descrição do evento"

            };

            EventoRepository.CadastrarEvento(eventos);
            EventoRepository.CadastrarEvento(eventos1);
            EventoRepository.CadastrarEvento(eventos2);
            EventoRepository.CadastrarEvento(eventos3);
        }
    }
}

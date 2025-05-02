using System;
using System.Collections.Generic;
using Acelera.Exceptions;
using Acelera.Models;
using Acelera.Repositories;
using Acelera.Exceptions;

namespace Acelera.Controllers
{
    public class EventosController
    {
        private bool ValidarEvento(Eventos evento)
        {
            return !string.IsNullOrEmpty(evento.NomeEvento) &&
                   !string.IsNullOrEmpty(evento.Tipo) &&
                   !string.IsNullOrEmpty(evento.Cidade) &&
                   evento.Data > DateTime.Now && // NOVA VALIDAÇÃO: Data deve ser no futuro
                   !string.IsNullOrEmpty(evento.Rua) &&
                   !string.IsNullOrEmpty(evento.Numero) &&
                   !string.IsNullOrEmpty(evento.Colaborador);
        }
        public bool CadastrarEvento(Eventos novoEvento)
        {
            return EventoRepository.CadastrarEvento(novoEvento);
        }

        public List<Eventos> ListarEventos()
        {
            return EventoRepository.ListarEventos();
        }

        public List<Eventos> ObterEventosPorTipo(string tipo)
        {
            return EventoRepository.ObterEventosPorTipo(tipo);
        }

        public List<Eventos> ObterEventosPorEstado(string estado)
        {
            return EventoRepository.ObterEventosPorEstado(estado);
        }

        public bool RemoverEvento(int id)
        {
            return EventoRepository.RemoverEvento(id);
        }
        public bool AtualizarEvento(int id, Eventos eventoAtualizado)
        {
            if (eventoAtualizado == null)
            {
                throw new ArgumentNullException(nameof(eventoAtualizado));
            }

            if (!EventoRepository.AtualizarEvento(id, eventoAtualizado))
            {
                throw new EventoNaoEncontradoException(id);
            }

            return true;
        }
    }
}



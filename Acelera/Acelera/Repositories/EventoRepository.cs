using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Acelera.Models;

namespace Acelera.Repositories
{
    public static class EventoRepository
    {
        private static List<Eventos> eventos = new List<Eventos>();

        private static int lastIdGenerated = 0;

        public static int generateId()
        {
            return lastIdGenerated++;
        }

        public static bool CadastrarEvento(Eventos novoEvento)
        {
            eventos.Add(novoEvento);
            return true;
        }


        public static List<Eventos> ListarEventos()
        {
            return eventos;
        }

        public static List<Eventos> ObterEventosPorTipo(string tipo)
        {
            return eventos.Where(e => e.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Eventos> ObterEventosPorEstado(string estado)
        {
            return eventos.Where(e => e.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static List<Eventos> ObterEventosPorColaborador(string colaborador)
        {
            return eventos.Where(e => e.Colaborador.Equals(colaborador, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static int? ObterIdDoEventoPorColaboradorENome(string colaborador, string nome)
        {
            var evento = eventos.FirstOrDefault(e =>
                e.Colaborador.Equals(colaborador, StringComparison.OrdinalIgnoreCase) &&
                e.NomeEvento.Equals(nome, StringComparison.OrdinalIgnoreCase));

            return evento?.Id;
        }
        public static bool RemoverEvento(int id)
        {
            var evento = eventos.FirstOrDefault(e => e.Id == id);
            if (evento != null)
            {
                eventos.Remove(evento);
                return true;
            }
            return false;
        }
        public static bool AtualizarEvento(int id, Eventos eventoAtualizado)
        {
            var eventoExistente = eventos.FirstOrDefault(e => e.Id == id);

            if (eventoExistente != null)
            {
                if (!string.IsNullOrEmpty(eventoAtualizado.NomeEvento))
                    eventoExistente.NomeEvento = eventoAtualizado.NomeEvento;

                if (!string.IsNullOrEmpty(eventoAtualizado.Descricao))
                    eventoExistente.Descricao = eventoAtualizado.Descricao;

                if (!string.IsNullOrEmpty(eventoAtualizado.Tipo))
                    eventoExistente.Tipo = eventoAtualizado.Tipo;

                if (!string.IsNullOrEmpty(eventoAtualizado.Cidade))
                    eventoExistente.Cidade = eventoAtualizado.Cidade;

                if (!string.IsNullOrEmpty(eventoAtualizado.Estado))
                    eventoExistente.Estado = eventoAtualizado.Estado;

                if (eventoAtualizado.Data != default(DateTime))
                    eventoExistente.Data = eventoAtualizado.Data;

                if (!string.IsNullOrEmpty(eventoAtualizado.Rua))
                    eventoExistente.Rua = eventoAtualizado.Rua;

                if (!string.IsNullOrEmpty(eventoAtualizado.Numero))
                    eventoExistente.Numero = eventoAtualizado.Numero;

                if (!string.IsNullOrEmpty(eventoAtualizado.Colaborador))
                    eventoExistente.Colaborador = eventoAtualizado.Colaborador;

                if (eventoAtualizado.Imagem != null)
                    eventoExistente.Imagem = eventoAtualizado.Imagem;

                return true;
            }

            return false;
        }

    }
}

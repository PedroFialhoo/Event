using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera.Models;

namespace Acelera.Repositories
{
    public static class EventoRepository
    {
        public static List<Eventos> eventos = new List<Eventos>();

        public static bool CadastrarEvento(Eventos novoEvento)
        {
            eventos.Add(novoEvento);

            return true;
        }

        public static List <Eventos> ListarEventos()
        {
            return eventos;
        }

        public static Eventos obterEventoPorTipo(string tipo)
        {
            return eventos.Find(e => e.Tipo == tipo);
        }
        public static Eventos obterEventoPorEstado(string estado)
        {
            return eventos.Find(e => e.Estado == estado);
        }
        public static Eventos RemoverEvento(string nomeEvento, string colaborador)
        {
            var evento = eventos.Find(e => e.NomeEvento == nomeEvento && e.Colaborador == colaborador);

            if (evento != null)
            {
                eventos.Remove(evento);
                return evento;
            }

            return null;
        }

    }
}

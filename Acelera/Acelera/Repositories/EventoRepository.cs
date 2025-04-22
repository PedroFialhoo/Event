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

        public static bool CadastrarEvento(string nome, string descricao, string tipo, string cidade, string local, string data, string colaborador)
        {
            int id = eventos.Count;
            Eventos novoEvento = new Eventos(id, nome, descricao, tipo, cidade, data, local, colaborador);
            eventos.Add(novoEvento);

            return true;
        }

    }
}

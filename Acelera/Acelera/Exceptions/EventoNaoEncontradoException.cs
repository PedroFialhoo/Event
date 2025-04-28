using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera.Exceptions
{
    public class EventoNaoEncontradoException : Exception
    {
        public EventoNaoEncontradoException(int id)
            : base($"Evento com ID {id} não encontrado.")
        {
        }
    }
}

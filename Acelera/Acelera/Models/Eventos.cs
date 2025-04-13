using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera.Models
{
    internal class Eventos
    {
        public int Id { get; set; }
        public string NomeEvento { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Cidade { get; set; }
        public string Data { get; set; }// ver o type date.time, as vzs é melhor que string
        public string Local {  get; set; }
        public string Colaborador { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera.Models
{
    public class ListaParticipantes
    {
        public int idParticipante { get; set; }
        public string codeParticipante { get; set; } //codigo do evento + cpf
        public bool participacao { get; set; }
    }
}

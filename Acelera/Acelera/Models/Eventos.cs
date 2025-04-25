using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera.Models
{
    public class Eventos
    {
        public int Id { get; set; }
        public string NomeEvento { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Data { get; set; }// ver o type date.time, as vzs é melhor que string
        public string Local {  get; set; }
        public string Colaborador { get; set; }
        public Image Imagem { get; set; }

      /*  public Eventos(int id, string nome, string descricao, string tipo, string cidade, string estado, string data, string local, string colaborador)
        {
            Id = id;
            NomeEvento = nome;
            Descricao = descricao;  
            Tipo = tipo;
            Cidade = cidade;
            Estado = estado;
            Data = data;
            Local = local;
            Colaborador = colaborador;

        }*/
    }
}

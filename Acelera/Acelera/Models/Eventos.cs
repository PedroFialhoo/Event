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
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Horario { get; set; }
        public DateTime Data { get; set; }
        public string Rua {  get; set; }
        public string Numero { get; set; }
        public string Colaborador { get; set; }
        public Image Imagem { get; set; }
        public string Code { get; set; }
        public bool Online { get; set; }
        public string Link { get; set; } = "Link indisponível";

        public List<ListaParticipantes> ParticipantesIds { get; set; } = new List<ListaParticipantes>();

        public Eventos(int id, string nome, string descricao, string tipo, string cidade, string estado, string horario, DateTime data, string rua, string numero, string colaborador, Image imagem, string code, bool online, string cep)
        {
            Id = id;
            NomeEvento = nome;
            Descricao = descricao;
            Tipo = tipo;
            Cidade = cidade;
            Estado = estado;
            Horario = horario;
            Data = data;
            Rua = rua;
            Numero = numero;
            Colaborador = colaborador;
            Imagem = imagem;
            Code = code;
            Online = online;
            Cep = cep;
        }

        public Eventos(string link)
        {
            Link = link;
        }
        public Eventos() { }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Acelera.Models
{
    public class Comunidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public List<string> Participantes { get; set; } = new List<string>();
        public List<Publicacao> Publicacoes { get; set; } = new List<Publicacao>(); 
        public string Foto { get; set; }

        public Comunidade(int id, string nome, string categoria, string descricao, string responsavel)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Descricao = descricao;
            Responsavel = responsavel;
            Participantes.Add(responsavel); 
            Publicacoes = new List<Publicacao>(); 
        }

        public void AdicionarPublicacao(Publicacao publicacao)
        {
            Publicacoes.Add(publicacao);
        }
    }
    public class Publicacao
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public Image Imagem { get; set; }
        public Publicacao(int id, string autor, string mensagem, DateTime data, Image imagem)
        {
            Id = id;
            Autor = autor;
            Mensagem = mensagem;
            Data = data;
            Imagem = imagem;
        }

    }
}

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
        public string Categoria { get; set; }
        public List<string> Participantes { get; set; } = new List<string>();
        public List<Publicacao> Publicacoes { get; set; } = new List<Publicacao>();
    }
    public class Publicacao
    {
        public string Autor { get; private set; }
        public string Mensagem { get; private set; }
        public DateTime Data { get; private set; } = DateTime.Now;
        public Image Imagem { get; set; }

        public List<string> Curtidas { get; set; } = new List<string>();
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Publicacao(string mensagem, string autor)
        {
            if (mensagem.Length > 1000)
                throw new ArgumentException("A publicação deve ter no máximo 1000 caracteres.");

            Mensagem = mensagem;
            Autor = autor;
        }
    }
    public class Comentario
    {
        public string Autor { get; private set; }
        public string Mensagem { get; private set; }
        public DateTime Data { get; private set; }

        public Comentario(string mensagem, string autor)
        {
            if (mensagem.Length > 280)
                throw new ArgumentException("O comentário deve ter no máximo 280 caracteres.");

            Mensagem = mensagem;
            Autor = autor;
            Data = DateTime.Now;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

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
        public string Autor { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string ImagemBase64 { get; set; }
        public List<string> Curtidas { get; set; } = new List<string>();
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public List<string> EuVou { get; set; } = new List<string>();
        public List<string> EuFui { get; set; } = new List<string>();

        public Publicacao() { }
        public Publicacao(string mensagem, string autor, Image imagem = null)
        {
            if (mensagem.Length > 1000)
                throw new ArgumentException("A publicação deve ter no máximo 1000 caracteres.");

            Mensagem = mensagem;
            Autor = autor;
            Data = DateTime.Now;

            if (imagem != null)
                ImagemBase64 = ConverterImagem(imagem);
        }
        public static string ConverterImagem(Image imagem)
        {
            using (var ms = new MemoryStream())
            {
                imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        public static Image ConverterBase(string base64)
        {
            if (string.IsNullOrEmpty(base64)) return null;
            byte[] bytes = Convert.FromBase64String(base64);
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        public Image ObterImagem()
        {
            return ConverterBase(ImagemBase64);
        }
        public bool SeloVou { get; set; } = false;
        public bool SeloFui { get; set; } = false;
    }

    public class Comentario
    {
        public string Autor { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public List<Comentario> Respostas { get; set; } = new List<Comentario>();

        public Comentario(string mensagem, string autor)
        {
            if (mensagem.Length > 280)
                throw new ArgumentException("O comentário deve ter no máximo 280 caracteres.");

            Autor = autor;
            Mensagem = mensagem;
            Data = DateTime.Now;
        }
    }
}

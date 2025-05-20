using Acelera.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Acelera.Repositories
{
    public class ComunidadeRepository
    {
        // Pasta onde os arquivos JSON serão salvos.
        private readonly string dadosPasta = "dados";
        private List<Comunidade> comunidades = new List<Comunidade>();

        public ComunidadeRepository()
        {
            // Garante que a pasta exista.
            Directory.CreateDirectory(dadosPasta);
        }
        public Comunidade ObterOuCriarPorCategoria(string categoria)
        {
            string caminho = Path.Combine(dadosPasta, $"comunidade_{categoria.ToLower()}.json");

            if (File.Exists(caminho))
            {
                string json = File.ReadAllText(caminho);
                var comunidade = System.Text.Json.JsonSerializer.Deserialize<Comunidade>(json);
                if (comunidade != null)
                {
                    return comunidade;
                }
            }

            var novaComunidade = new Comunidade { Categoria = categoria };
            SalvarComunidade(novaComunidade);
            comunidades.Add(novaComunidade);
            return novaComunidade;
        }


        // Salva a comunidade em um arquivo JSON.
        public void SalvarComunidade(Comunidade comunidade)
        {
            string caminho = Path.Combine(dadosPasta, $"comunidade_{comunidade.Categoria.ToLower()}.json");
            var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
            string json = System.Text.Json.JsonSerializer.Serialize(comunidade, options);
            File.WriteAllText(caminho, json);
        }

        public bool AdicionarParticipante(string categoria, string usuario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (!comunidade.Participantes.Contains(usuario))
            {
                comunidade.Participantes.Add(usuario);
                SalvarComunidade(comunidade);
                return true;
            }
            return false;
        }
        public bool SairDaComunidade(string categoria, string usuario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (comunidade.Participantes.Contains(usuario))
            {
                comunidade.Participantes.Remove(usuario);
                SalvarComunidade(comunidade);
                return true;
            }
            return false;
        }
        public bool AdicionarPublicacao(string categoria, Publicacao publicacao)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            comunidade.Publicacoes.Add(publicacao);
            SalvarComunidade(comunidade);
            return true;
        }
        public bool ComentarPublicacao(string categoria, int indicePublicacao, Comentario comentario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (comunidade.Publicacoes.Count > indicePublicacao)
            {
                comunidade.Publicacoes[indicePublicacao].Comentarios.Add(comentario);
                SalvarComunidade(comunidade);
                return true;
            }
            return false;
        }
        public bool ResponderComentario(string categoria, int indicePublicacao, int indiceComentarioPai, Comentario resposta)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (comunidade.Publicacoes.Count > indicePublicacao)
            {
                var publicacao = comunidade.Publicacoes[indicePublicacao];
                if (publicacao.Comentarios.Count > indiceComentarioPai)
                {
                    publicacao.Comentarios[indiceComentarioPai].Respostas.Add(resposta);
                    SalvarComunidade(comunidade);
                    return true;
                }
            }
            return false;
        }
        public bool CurtirPublicacao(string categoria, int indicePublicacao, string usuario)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            if (comunidade.Publicacoes.Count > indicePublicacao)
            {
                var pub = comunidade.Publicacoes[indicePublicacao];
                if (!pub.Curtidas.Contains(usuario))
                {
                    pub.Curtidas.Add(usuario);
                    SalvarComunidade(comunidade);
                    return true;
                }
            }
            return false;
        }
        public List<Publicacao> ListarPublicacoes(string categoria)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            return comunidade.Publicacoes;
        }
        public List<string> ListarParticipantes(string categoria)
        {
            var comunidade = ObterOuCriarPorCategoria(categoria);
            return comunidade.Participantes;
        }
    }
}



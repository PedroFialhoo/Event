using System;
using System.Collections.Generic;
using Acelera.Models;

namespace Acelera.Controllers
{
    public class CadastroAutomaticoComunidades
    {
        public static List<Comunidade> comunidades = new List<Comunidade>();

        public static void Executar()
        {
            var categorias = new List<string>
            {
                "computacao",
                "educacao",
                "empreendedorismo",
                "esporte",
                "musica",
                "saude"
            };

            foreach (var categoria in categorias)
            {
                Comunidade comunidade = new Comunidade
                {
                    Categoria = categoria
                };

                for (int i = 1; i <= 3; i++)
                {
                    Publicacao publicacao = new Publicacao
                    {
                        Autor = $"Autor_{categoria}_{i}",
                        Mensagem = $"Esta é uma publicação de exemplo {i} na categoria {categoria}.",
                        Data = DateTime.Now
                    };

                    for (int j = 1; j <= 2; j++)
                    {
                        Comentario comentario = new Comentario(
                            $"Comentário {j} na publicação {i} de {categoria}",
                            $"Comentarista_{j}"
                        );

                        publicacao.Comentarios.Add(comentario);
                    }

                    comunidade.Publicacoes.Add(publicacao);
                }

                comunidades.Add(comunidade);
            }
        }
    }
}

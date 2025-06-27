using System;
using System.Drawing;
using Acelera.Properties;
using System.IO;
using System.Drawing.Text;
using Acelera.Models;
using Acelera.Repositories;

namespace Acelera.Controllers
{
    public class CertificateController
    {
        public static void GerarCertificado(Usuario user, Eventos evento)
        {
            string pastaDownloads = System.IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "Downloads");
            string caminhoSaida = GerarNomeArquivoUnico(pastaDownloads, "certificado_participacao", ".png");
            string nomeCompleto = user.Nome.Trim();
            string[] partes = nomeCompleto.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            string primeiroNome = partes[0];
            string ultimoNome = partes.Length > 1 ? partes[partes.Length - 1] : partes[0];

            string nomeUsuario = primeiroNome + " " + ultimoNome;
            string nomeEvento = evento.NomeEvento;
            string codigoEvento = EventoRepository.ObterCodigoParticipante(evento.Id, user.Id);

            using (Image imagem = (Image)Resources.certificado.Clone())
            {
                using (Graphics g = Graphics.FromImage(imagem))
                {
                    string caminhoFonte = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts", "Parisienne-Regular.ttf");

                    PrivateFontCollection pfc = new PrivateFontCollection();
                    pfc.AddFontFile(caminhoFonte);

                    Font fonteNome = new Font(pfc.Families[0], 45, FontStyle.Regular);
                    Font fonteNomeEvento = new Font(pfc.Families[0], 36, FontStyle.Regular);
                    Font fonteCodigo = new Font("Arial", 18);
                    Brush corTexto = Brushes.Black;

                    PointF posicaoNome = new PointF(420, 677);
                    g.DrawString(nomeUsuario, fonteNome, corTexto, posicaoNome);

                    PointF posicaoNomeEvento = new PointF(590, 930);
                    g.DrawString(nomeEvento, fonteNomeEvento, corTexto, posicaoNomeEvento);

                    PointF posicaoCodigo = new PointF(190, 1160);
                    g.DrawString(codigoEvento, fonteCodigo, corTexto, posicaoCodigo);
                }

                imagem.Save(caminhoSaida);
                System.Diagnostics.Debug.WriteLine($"CERTIFICADO: {caminhoSaida}");
            }
        }
        private static string GerarNomeArquivoUnico(string pasta, string nomeBase, string extensao)
        {
            string caminho = Path.Combine(pasta, $"{nomeBase}{extensao}");
            int contador = 1;

            while (File.Exists(caminho))
            {
                caminho = Path.Combine(pasta, $"{nomeBase}({contador}){extensao}");
                contador++;
            }

            return caminho;
        }

    }
}

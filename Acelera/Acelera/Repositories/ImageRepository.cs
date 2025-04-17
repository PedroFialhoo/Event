using System;
using System.Drawing;
using System.IO;

namespace Acelera.Repositories
{
    public static class ImagemRepository
    {
        public static byte[] ConverterImagemParaBytes(Image imagem)
        {
            if (imagem == null) return null;

            using (var ms = new MemoryStream())
            {
                imagem.Save(ms, imagem.RawFormat);
                return ms.ToArray();
            }
        }

        public static byte[] CarregarImagem(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                return File.ReadAllBytes(caminhoArquivo);
            }
            else
            {
                Console.WriteLine("Arquivo de imagem não encontrado.");
                return null;
            }
        }

        public static bool SalvarImagem(byte[] imagem, string caminhoArquivo)
        {
            if (imagem != null)
            {
                try
                {
                    File.WriteAllBytes(caminhoArquivo, imagem);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao salvar a imagem: {ex.Message}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Imagem não fornecida.");
                return false;
            }
        }

        public static Image ConverterParaImagem(byte[] imagemBytes)
        {
            if (imagemBytes != null && imagemBytes.Length > 0)
            {
                using (var ms = new MemoryStream(imagemBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }
    }
}

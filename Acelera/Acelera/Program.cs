using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Controllers;
using Acelera.Forms;
using Acelera.Models;
using Acelera.Repositories;
using Acelera.Views;
using System.Drawing;
using System.IO;
namespace Acelera
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            CadastroAutomatico.Executar();
            CadastroAutomaticoComunidades.Executar();
            Console.WriteLine($"Comunidades cadastradas: {CadastroAutomaticoComunidades.comunidades.Count}");
            Application.Run(new TelaInicial());
        }
    }
}
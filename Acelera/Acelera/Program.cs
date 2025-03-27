using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Forms;

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
            Application.SetCompatibleTextRenderingDefault(false);
            TelaLogin telaLogin = new TelaLogin();  
            telaLogin.WindowState = FormWindowState.Maximized;
            Application.Run(telaLogin);
        }
    }
}

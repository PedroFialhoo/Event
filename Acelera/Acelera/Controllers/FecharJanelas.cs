using Acelera.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Acelera.ferramentas
{
    public class FecharJanelas
    {
        public static void CloseSystem()
        {
            // Verifica se não há nenhum formulário aberto
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit(); // Fecha o sistema se não houver formulários abertos
            }
            else
            {
                // Procura por formulários abertos
                foreach (Form formularioAberto in Application.OpenForms)
                {
                    // Se encontrar o formulário de login, mostra-o e fecha os outros
                    if (formularioAberto is TelaLogin)
                    {
                        formularioAberto.Show();
                        // Fecha todas as outras janelas abertas
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form != formularioAberto)
                            {
                                form.Close();
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
}

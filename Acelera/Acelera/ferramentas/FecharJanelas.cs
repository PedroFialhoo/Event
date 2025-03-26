using Acelera.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera.ferramentas
{
    public class FecharJanelas
    {
        public static void CloseSystem()
        {
            // Se não tiver nenhuma tela/formulario aberto, ele vai fechar o sistema
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                // se tiver alguma tela aberta, vai procurar por quias telas são
                foreach (Form FormularioAberto in Application.OpenForms)
                {
                    // se algumas dessas telas abertas for o Login, ao fechar a tela que estamos usando, ele vai retornar pro form1/TelaLogin
                    if (FormularioAberto is TelaLogin)
                    {
                        FormularioAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera.Controllers
{
    internal class VerificarCampos
    {
        private String email;
        private String senha;

        public static bool VerificarCampoEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, padraoEmail);
        }

        public static bool VerificarCampoSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                return false;

            return senha.Length >= 6;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Acelera.Controllers
{
    internal class PasswordController
    {        
    private Byte[] salt = new byte[16];
        public Boolean VerificarSenha(String senha)
        {
            Boolean caractereEspecial = Regex.IsMatch(senha, "[@#!$%&]");
            Boolean caractereNumerico = Regex.IsMatch(senha, "[0-9]");
            Boolean caractereMaiusculo = Regex.IsMatch(senha, "[A-Z]");
            Boolean tamanho = senha.Length >= 8 ? true : false;
            if (caractereEspecial && caractereNumerico && caractereMaiusculo && tamanho)
            {
                System.Diagnostics.Debug.WriteLine("senha valida");
                return true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("senha fornecida não atende aos padroes pedidos");
                return false;
            }
        }
        
    }
}

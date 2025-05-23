using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace Acelera.Models
{
    public class Login
    {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
            public string Cnpj { get; set; }

            public string CodeQR { get; set; }

            public Login(int id, string email, string senha)
            {
                Id = id;
                Email = email;
                Senha = senha;
                CodeQR = Guid.NewGuid().ToString();
        }
            public Login(int id, string email, string senha, string cnpj)
            {
                Id = id;
                Email = email;
                Senha = senha;
                Cnpj = cnpj;
            }

    }
}

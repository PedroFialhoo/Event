using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera.Models
{
    public class Login
    {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }

            public Login(int id, string email, string senha)
            {
                Id = id;
                Email = email;
                Senha = senha;
            }        

    }
}

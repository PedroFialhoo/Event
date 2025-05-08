using System;
using System.Drawing;
using Acelera.Repositories;

namespace Acelera.Models
{
    public class Usuario
    {
        public int Id { get; set; } // ID do usuário, que será vinculado ao Login
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Image Imagem { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeEmpresa { get; set; }
        public string Document { get; set; }
        public string Telefone { get; set; }
        public Image Imagem { get; set; }

        
    }
}

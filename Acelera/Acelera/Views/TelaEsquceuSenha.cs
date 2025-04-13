using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera.Forms
{
    public partial class TelaEsquceuSenha: Form
    {
        private string codigo;
        public TelaEsquceuSenha(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            
        }

        private void TelaEsquceuSenha_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == codigo)
            {
                //processo pra salvar nova senha
            }
            else
            {
                MessageBox.Show("Código de recuperação incorreto");
            }
        }
    }
}

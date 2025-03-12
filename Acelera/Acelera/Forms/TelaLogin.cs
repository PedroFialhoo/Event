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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            TelaCadastro telaCadastro = new TelaCadastro();

            telaCadastro.WindowState = FormWindowState.Maximized;
            telaCadastro.Show();
            this.Hide(); // O Dispose(); ou o Close(); estava fazendo fechar antes de abrir a tela, ai to usando o Hide(); , porém ele deixa ativo em segundo plano.
            telaCadastro.FormClosed += (s, args) => this.Close(); // essa função faz com que ao fechar a tela cadastro essa tela seja fechada, pra não causar conflito ou ocupar memória desnecessária.
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

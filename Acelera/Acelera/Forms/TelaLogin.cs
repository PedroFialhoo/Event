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
    public partial class Event : Form
    {
        public Event()
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
            this.Visible = false;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {
            TelaCriarPerfil telaCriarPerfil = new TelaCriarPerfil();            
            telaCriarPerfil.WindowState = FormWindowState.Maximized;
            telaCriarPerfil.Show();
            this.Hide(); 
            telaCriarPerfil.FormClosed += (s, args) => this.Close();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(campoEmail.Text) && !string.IsNullOrWhiteSpace(campoSenha.Text))
            {
                //if para verificar login
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }
=======
        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (!String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(senha))
            {
                // aqui ele vai ser encaminhado para tela inicial do programa
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Informe seu e-mail e senha para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
    }
}

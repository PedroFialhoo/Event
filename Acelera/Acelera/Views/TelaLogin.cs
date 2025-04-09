using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Controllers;


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
            telaCadastro.Show();
            this.Visible = false;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            TelaCriarPerfil telaCriarPerfil = new TelaCriarPerfil(); 
            telaCriarPerfil.Show();
            this.Hide(); 
            telaCriarPerfil.FormClosed += (s, args) => this.Close();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerificarCampos.VerificarCampoEmail(email))
            {
                MessageBox.Show("E-mail inválido! Digite um e-mail correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            telaCadastro.FormClosed += (s, args) => this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaEsquceuSenha telaEsquceuSenha = new TelaEsquceuSenha();
            telaEsquceuSenha.Show();
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}


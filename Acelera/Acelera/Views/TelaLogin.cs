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
using Acelera.Models;
using Acelera.Repositories;
using Acelera.Views;


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
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
        }

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailRecuperacao email = new EmailRecuperacao();
            string destinatario = txtEmail.Text;
            string codigo = CodigoRecuperacao.GerarCodigoNumerico();

            if (email.EnviarEmail(destinatario, codigo))
            {
                MessageBox.Show("E-mail de recuperação enviado com sucesso!");
            }

            TelaEsquceuSenha telaEsquceuSenha = new TelaEsquceuSenha(codigo);
            telaEsquceuSenha.Show();
            this.Close();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            EmailController emailController = new EmailController();
            emailController.ValidarEmail(email);

            Login login = LoginRepository.Autenticar(email, senha);

            if (login != null)
            {
                int idUsuarioLogado = login.Id;
                var perfil = UsuarioRepository.ObterUsuarioPorId(login.Id);

                if (perfil == null)
                {
                    TelaCriarPerfil criarPerfil = new TelaCriarPerfil();
                    criarPerfil.Show();
                    this.Close();
                }
                else
                {
                    TelaPrincipal telaPrincipal = new TelaPrincipal();
                    telaPrincipal.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos.");
            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar= true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaLoginColaborador telaLoginColaborador = new TelaLoginColaborador();
            telaLoginColaborador.Show();
            this.Close();
        }
    }
}


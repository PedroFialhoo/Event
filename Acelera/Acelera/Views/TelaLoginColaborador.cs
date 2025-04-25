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
using Acelera.Forms;
using Acelera.Models;
using Acelera.Repositories;

namespace Acelera.Views
{
    public partial class TelaLoginColaborador : Form
    {
        public TelaLoginColaborador()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroColaborador telaCadastro = new TelaCadastroColaborador();
            telaCadastro.Show();
            telaCadastro.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
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

            if (!VerificarCampos.VerificarCampoEmail(email))
            {
                MessageBox.Show("E-mail inválido! Digite um e-mail correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Login login = LoginColaboradorRepository.Autenticar(email, senha);

            if (login != null)
            {
                int idUsuarioLogado = login.Id;
                var perfil = ColaboradorRepository.ObterColaboradorPorId(login.Id);

                /* if (perfil == null)
                 {
                     // Não existe perfil, abre a tela de criação
                     TelaCriarPerfil criarPerfil = new TelaCriarPerfil();
                     criarPerfil.Show(); // criar tela perfil de colaborador
                 }
                 else
                 {
                     TelaCriarEvento telaCriarEvento = new TelaCriarEvento();
                    telaCriarEvento.Show();
                 }*/
            }
            else
            {
                // Se o login falhar
                MessageBox.Show("Email ou senha inválidos.");
            }
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
    }
}

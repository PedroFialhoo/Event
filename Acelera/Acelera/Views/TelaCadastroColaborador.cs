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
using Acelera.Repositories;

namespace Acelera.Views
{
    public partial class TelaCadastroColaborador : Form
    {
        public TelaCadastroColaborador()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string repeteSenha = txtRepeteSenha.Text;
            string cnpj = txtCnpj.Text;

            EmailController emailController = new EmailController();
            PasswordController passwordController = new PasswordController();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(repeteSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            emailController.ValidarEmail(email);
            passwordController.VerificarSenha(senha);

            if (senha != repeteSenha)
            {
                MessageBox.Show("As senhas devem coincidir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DocumentController.VerificaCNPJ(txtCnpj.Text))
            {
                MessageBox.Show("Insira um CNPJ válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool cadastrado = LoginColaboradorRepository.Cadastrar(email, senha, cnpj);
            EmailRecuperacao emailRecuperacao = new EmailRecuperacao();

            if (cadastrado)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                TelaLoginColaborador telaLogin = new TelaLoginColaborador();
                telaLogin.Show();
            }
            else
            {
                DialogResult resposta = MessageBox.Show(
                    "E-mail já está cadastrado. Deseja redefinir a senha?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resposta == DialogResult.Yes)
                {

                    string destinatario = txtEmail.Text;
                    string codigo = CodigoRecuperacao.GerarCodigoNumerico();

                    if (emailRecuperacao.EnviarEmail(destinatario, codigo))
                    {
                        MessageBox.Show("E-mail de recuperação enviado com sucesso!");
                    }

                    TelaEsquceuSenha telaEsquceuSenha = new TelaEsquceuSenha(codigo);
                    telaEsquceuSenha.Show();
                }
            }
        }
    }
}

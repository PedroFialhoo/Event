using Acelera.Controllers;
using Acelera.ferramentas;
using Acelera.Models;
using Acelera.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Acelera.Forms
{
    public partial class TelaCadastro : Form
    {

        private Form TelaLogin;
        public TelaCadastro()
        {
            InitializeComponent();

        }
        public TelaCadastro(Form TelaLogin)
        {
            InitializeComponent();

            this.TelaLogin = TelaLogin;
        }
        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string repeteSenha = txtRepeteSenha.Text;
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
            bool cadastrado = LoginRepository.Cadastrar(email, senha);
            EmailRecuperacao emailRecuperacao = new EmailRecuperacao();

            if (cadastrado)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                TelaLogin telaLogin = new TelaLogin();
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

        private void TelaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            FecharJanelas.CloseSystem();
        }

       

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

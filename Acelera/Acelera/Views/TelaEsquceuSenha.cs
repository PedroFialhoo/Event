using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                string novaSenha = txtSenha.Text;
                string email = txtEmail.Text;
                bool alterado = LoginRepository.RedefinirSenha(email, novaSenha);
                if( txtSenha.Text == txtRepeteSenha.Text)
                {
                    if (alterado)
                    {
                        MessageBox.Show("Senha redefinida com sucesso!");
                        TelaLogin telaLogin = new TelaLogin();
                        telaLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao redefinir a senha. E-mail não encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Senhas diferentes");
                }
                

            }
            else
            {
                MessageBox.Show("Código de recuperação incorreto");
            }
        }
    }
}

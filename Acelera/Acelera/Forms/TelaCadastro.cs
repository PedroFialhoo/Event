using Acelera.ferramentas;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string cofirmaSenha = txtConfirmaSenha.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(cofirmaSenha))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (senha != cofirmaSenha)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.TelaLogin.Visible = true;
            this.Close();
        }

        private void TelaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            FecharJanelas.CloseSystem();
        }
    }
}

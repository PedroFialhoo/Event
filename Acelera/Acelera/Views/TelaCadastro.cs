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
        UsuarioRepository usuarioRepo = new UsuarioRepository();

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
            string email = Console.ReadLine();
            usuarioRepo.Adicionar(new Usuario { Email = email});
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string senha = Console.ReadLine();
            usuarioRepo.Adicionar(new Usuario { Senha = senha });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string repeteSenha = txtRepeteSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(repeteSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerificarCampos.VerificarCampoEmail(email))
            {
                MessageBox.Show("E-mail inválido! Digite um e-mail correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!VerificarCampos.VerificarCampoSenha(senha))
            {
                MessageBox.Show("A senha deve conter no mínimo 6 dígitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (senha != repeteSenha)
            {
                MessageBox.Show("As senhas devem coincidir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TelaCriarPerfil telaCriarPerfil = new TelaCriarPerfil();
            telaCriarPerfil.Show();

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Models;
using Acelera.Repositories;
using Acelera.Views;
using QRCoder;

namespace Acelera.Forms
{
    public partial class TelaPerfil: Form
    {
        private Usuario usuario;
        private int? idLogado = LoginRepository.GetUsuarioLogadoId();
        public TelaPerfil(Usuario usuarioLogado)
        {
            InitializeComponent();
            usuario = usuarioLogado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            lblNome.Text = usuario.Nome;
            //lblIdade.Text = usuario.Idade.ToString();
            lblTelefone.Text = usuario.Telefone;
            //lblCpf.Text = usuario.Cpf;
            lblCidade.Text = usuario.Cidade;
            lblEstado.Text = usuario.Estado;


            if (usuario.Imagem != null)
            {
                pictureBoxPerfil.Image = usuario.Imagem;
            }


            if (!string.IsNullOrEmpty(usuario.CodigoQr))
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(usuario.CodigoQr, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                CodeQR_box.Image = qrCode.GetGraphic(20);
               // MessageBox.Show(usuario.CodigoQr ?? "Código QR vazio");// Testar unico qr
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginRepository.Sair();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPerfil_Click(object sender, EventArgs e)
        {

        }
        

        private void menuItemDeslogar_Click(object sender, EventArgs e)
        {
            LoginRepository.Sair();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            menuOpcoes.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void menuItemEditar_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginRepository.GetUsuarioLogadoId();
            Usuario usuarioLogado = UsuarioRepository.ObterUsuarioPorId(idUsuarioLogado.Value);
            TelaEditarPerfil telaEditarPerfil = new TelaEditarPerfil(usuarioLogado);
            telaEditarPerfil.Show();
        }

        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir a conta?\nTodos os dados serão exluídos permanentemente, incluindo os eventos relacionados à conta", "Excluir conta permanentemente!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                bool sucesso = LoginRepository.ExcluirConta(idLogado.Value);
                if (sucesso)
                {
                    MessageBox.Show("Conta excluída com sucesso!");
                    LoginRepository.Sair();
                    TelaLogin telaLogin = new TelaLogin();
                    telaLogin.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir conta!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CodeQR_box_Click(object sender, EventArgs e)
        {
            this.CodeQR_box = new System.Windows.Forms.PictureBox();
        }
    }
}

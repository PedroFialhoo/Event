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

namespace Acelera.Forms
{
    public partial class TelaCriarPerfil: Form
    {
        public TelaCriarPerfil()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCriarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            FecharJanelas.CloseSystem();
        }

        private void TelaCriarPerfil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                
                picturePerfil.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Erro: Nenhum usuário está logado.");
                return;
            }

            // Cria um novo objeto Usuario
            Usuario usuario = new Usuario
            {
                Id = idUsuarioLogado.Value, // Usa o ID do usuário logado
                Nome = txtNome.Text,
                Idade = int.Parse(txtIdade.Text),
                Telefone = txtTelefone.Text,
                Cpf = txtCPF.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Imagem = picturePerfil.Image

            };

            bool sucesso = UsuarioRepository.SalvarUsuario(usuario);

            if (sucesso)
            {
                MessageBox.Show("Perfil criado com sucesso!");
                TelaPerfil telaPerfil = new TelaPerfil(usuario);
                telaPerfil.Show();
            }
            else
            {
                MessageBox.Show("Já existe um perfil para esse usuário.");
            }
        }
    }
}

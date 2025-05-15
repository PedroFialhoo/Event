using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Forms;
using Acelera.Models;
using Acelera.Repositories;

namespace Acelera.Views
{
    public partial class TelaCriarPerfilColaborador : Form
    {
        public TelaCriarPerfilColaborador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginColaboradorRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Erro: Nenhum usuário está logado.");
                return;
            }

            Colaborador colaborador = new Colaborador
            {
                Id = idUsuarioLogado.Value, // Usa o ID do usuário logado
                Nome = txtNome.Text,
                NomeEmpresa = txtNomeEmpresa.Text,
                Telefone = txtTelefone.Text,
                Imagem = picturePerfil.Image

            };

            bool sucesso = ColaboradorRepository.CadastrarColaborador(colaborador);

            if (sucesso)
            {
                MessageBox.Show("Perfil criado com sucesso!");
                TelaPerfilColaborador telaPerfil = new TelaPerfilColaborador(colaborador);
                telaPerfil.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Já existe um perfil para esse usuário.");
            }
        
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Forms;
using Acelera.Models;
using Acelera.Repositories;
using Newtonsoft.Json;

namespace Acelera.Views
{
    public partial class TelaEditarPerfil : Form
    {

        private Usuario usuario;
        public TelaEditarPerfil(Usuario usuarioLogado)
        {
            InitializeComponent();

            usuario = usuarioLogado;
        }

        private async void txtCep_Leave(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido. Deve conter 8 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var endereco = JsonConvert.DeserializeObject<Endereco>(json);

                        if (endereco != null && endereco.uf != null)
                        {
                            txtCidade.Text = endereco.localidade;
                            txtEstado.Text = endereco.uf;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar o CEP: " + ex.Message);
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Erro: Nenhum usuário está logado.");
                return;
            }
            DateTime dataNascimento;
            if (!DateTime.TryParse(txtData.Text, out dataNascimento))
            {
                MessageBox.Show("Data inválida. Use o formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = new Usuario
            {
                Nome = txtNome.Text,
                DataNascimento = dataNascimento,
                Telefone = txtTelefone.Text,
                Cpf = txtCPF.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Imagem = picturePerfil.Image

            };

            bool sucesso = UsuarioRepository.AtualizarUsuario(idUsuarioLogado.Value, usuario);

            if (sucesso)
            {
                MessageBox.Show("Perfil Atualizado com sucesso!");
                TelaPerfil telaPerfil = new TelaPerfil(usuario);
                telaPerfil.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Já existe um perfil para esse usuário.");
            }
        }

        private void TelaEditarPerfil_Load(object sender, EventArgs e)
        {
            txtNome.Text = usuario.Nome;
            //lblIdade.Text = usuario.Idade.ToString();
            txtTelefone.Text = usuario.Telefone;
            //lblCpf.Text = usuario.Cpf;
            txtCidade.Text = usuario.Cidade;
            txtEstado.Text = usuario.Estado;

            if (usuario.Imagem != null)
            {
                picturePerfil.Image = usuario.Imagem;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário está logado.");
                return;
            }

            Usuario usuarioLogado = UsuarioRepository.ObterUsuarioPorId(idUsuarioLogado.Value);

            if (usuarioLogado != null)
            {
                TelaPerfil telaPerfil = new TelaPerfil(usuarioLogado);
                telaPerfil.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Perfil não encontrado.");
            }
        }
    }
}

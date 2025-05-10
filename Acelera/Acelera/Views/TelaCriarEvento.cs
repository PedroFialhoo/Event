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
using Acelera.Models;
using Acelera.Repositories;
using Newtonsoft.Json;

namespace Acelera.Views
{
    public partial class TelaCriarEvento : Form
    {
        public TelaCriarEvento()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)

        {
        if (string.IsNullOrWhiteSpace(txtNome.Text) ||
            string.IsNullOrWhiteSpace(txtDescricao.Text) ||
            string.IsNullOrEmpty(cbTipo.Text) ||
            cbTipo.SelectedIndex == 0 ||
            string.IsNullOrEmpty(txtCidade.Text) ||
            string.IsNullOrEmpty(txtEstado.Text) ||
            string.IsNullOrEmpty(txtCep.Text) ||
            string.IsNullOrEmpty(txtData.Text) ||
            string.IsNullOrEmpty(txtHorario.Text) ||
            string.IsNullOrEmpty(txtRua.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idUsuarioLogado = LoginColaboradorRepository.GetUsuarioLogadoId();
            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Usuário não está logado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataEvento;
            if (!DateTime.TryParse(txtData.Text, out dataEvento))
            {
                MessageBox.Show("Data inválida. Use o formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string colaborador = ColaboradorRepository.ObterNomeColaboradorPorId(idUsuarioLogado.Value);

            string mensagem = $"ID: {idUsuarioLogado}\n" +
                              $"Nome: {txtNome.Text}\n" +
                              $"Descrição: {txtDescricao.Text}\n" +
                              $"Tipo: {cbTipo.Text}\n" +
                              $"Cidade: {txtCidade.Text}\n" +
                              $"Estado: {txtEstado.Text}\n" +
                              $"Data: {txtData.Text}\n" +
                              $"Local: {txtRua.Text}\n" +
                              $"Colaborador: {colaborador}";

            Eventos evento = new Eventos
            {
                Id = EventoRepository.generateId(),
                NomeEvento = txtNome.Text,
                Descricao = txtDescricao.Text,
                Tipo = cbTipo.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Horario = txtHorario.Text,
                Data = dataEvento,
                Rua = txtRua.Text,
                Numero = txtNumero.Text,
                Colaborador = colaborador,
                Imagem = pictureEvento.Image
            };

            bool sucesso = EventoRepository.CadastrarEvento(evento);


            MessageBox.Show(sucesso ? "Evento criado com sucesso!" : "Evento já cadastrado.");

            if (sucesso)
            {
                Colaborador colaboradorLogado = ColaboradorRepository.ObterColaboradorPorId(idUsuarioLogado.Value);
                TelaPerfilColaborador telaPerfil = new TelaPerfilColaborador(colaboradorLogado);
                telaPerfil.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureEvento.Image = Image.FromFile(openFileDialog.FileName);
            }
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
                            txtRua.Text = endereco.logradouro;
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

        private void txtLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginColaboradorRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário está logado.");
                return;
            }

            Colaborador colaboradorLogado = ColaboradorRepository.ObterColaboradorPorId(idUsuarioLogado.Value);

            if (colaboradorLogado != null)
            {
                TelaPerfilColaborador telaPerfil = new TelaPerfilColaborador(colaboradorLogado);
                telaPerfil.Show();
            }
            else
            {
                MessageBox.Show("Perfil não encontrado.");
            }
        }
    }
}

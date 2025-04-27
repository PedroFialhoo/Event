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
            int? idUsuarioLogado = LoginRepository.GetUsuarioLogadoId();

            string colaborador = ColaboradorRepository.ObterNomeColaboradorPorId(idUsuarioLogado.Value);

            Eventos evento = new Eventos
            {
                Id = idUsuarioLogado.Value,
                NomeEvento = txtNome.Text,
                Descricao = txtDescricao.Text,
                Tipo = cbTipo.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Data = txtData.Text,
                Local = txtLocal.Text,
                Colaborador = colaborador,
                Imagem = pictureEvento.Image,
            };

            bool sucesso = EventoRepository.CadastrarEvento(evento);

            if (sucesso)
            {
                MessageBox.Show("Evento criado com sucesso!");
            }
            else
            {
                MessageBox.Show("Evento já cadastrado.");
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
    }
}

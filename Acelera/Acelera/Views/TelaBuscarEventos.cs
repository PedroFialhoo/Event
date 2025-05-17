using System;
using System.Drawing;
using System.Windows.Forms;
using Acelera.Models;
using Acelera.Repositories;
using System.Collections.Generic;
using Acelera.Forms;

namespace Acelera.Views
{
    public partial class TelaBuscarEventos : Form
    {
        private string categoria = null;
        public TelaBuscarEventos()
        {
            InitializeComponent();
        }
        public TelaBuscarEventos(string categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string nomeEvento = txtNomeEvento.Text;
            var eventosEncontrados = EventoRepository.ObterEventosPorNome(nomeEvento);

            flowPanelEventos.Controls.Clear(); // limpa resultados anteriores

            foreach (var evento in eventosEncontrados)
            {
                Panel eventoPanel = new Panel();
                eventoPanel.Width = 150;
                eventoPanel.Height = 180;
                eventoPanel.Margin = new Padding(10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 120;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                if (evento.Imagem != null)
                {
                    pictureBox.Image = evento.Imagem;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.festival_de_musica; 
                }

                pictureBox.Tag = evento;
                pictureBox.Cursor = Cursors.Hand;

                pictureBox.Click += (s, args) =>
                {
                    var pic = s as PictureBox;
                    var eventoSelecionado = pic.Tag as Eventos;
                    TelaExibirEvento tela = new TelaExibirEvento(eventoSelecionado);
                    tela.Show();
                };

                Label nomeLabel = new Label();
                nomeLabel.Text = evento.NomeEvento;
                nomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                nomeLabel.Dock = DockStyle.Bottom;
                nomeLabel.Font = new Font("Segoe UI", 14, FontStyle.Regular);

                eventoPanel.Controls.Add(pictureBox);
                eventoPanel.Controls.Add(nomeLabel);
                flowPanelEventos.Controls.Add(eventoPanel);
            }

            if (eventosEncontrados.Count == 0)
            {
                MessageBox.Show("Nenhum evento encontrado com esse nome.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }

        private void flowPanelEventos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void TelaBuscarEventos_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(categoria))
            {
                var eventosEncontrados = EventoRepository.ObterEventosPorTipo(categoria);

                flowPanelEventos.Controls.Clear(); // limpa resultados anteriores

                foreach (var evento in eventosEncontrados)
                {
                    Panel eventoPanel = new Panel();
                    eventoPanel.Width = 150;
                    eventoPanel.Height = 180;
                    eventoPanel.Margin = new Padding(10);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 150;
                    pictureBox.Height = 120;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    if (evento.Imagem != null)
                    {
                        pictureBox.Image = evento.Imagem;
                    }
                    else
                    {
                        pictureBox.Image = Properties.Resources.festival_de_musica;
                    }

                    pictureBox.Tag = evento;
                    pictureBox.Cursor = Cursors.Hand;

                    pictureBox.Click += (s, args) =>
                    {
                        var pic = s as PictureBox;
                        var eventoSelecionado = pic.Tag as Eventos;
                        TelaExibirEvento tela = new TelaExibirEvento(eventoSelecionado);
                        tela.Show();
                    };

                    Label nomeLabel = new Label();
                    nomeLabel.Text = evento.NomeEvento;
                    nomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    nomeLabel.Dock = DockStyle.Bottom;
                    nomeLabel.Font = new Font("Segoe UI", 14, FontStyle.Regular);

                    eventoPanel.Controls.Add(pictureBox);
                    eventoPanel.Controls.Add(nomeLabel);
                    flowPanelEventos.Controls.Add(eventoPanel);
                }

                if (eventosEncontrados.Count == 0)
                {
                    MessageBox.Show("Nenhum evento encontrado com esse nome.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var eventosEncontrados = EventoRepository.ListarEventos();
                flowPanelEventos.Controls.Clear(); // limpa resultados anteriores

                foreach (var evento in eventosEncontrados)
                {
                    Panel eventoPanel = new Panel();
                    eventoPanel.Width = 150;
                    eventoPanel.Height = 180;
                    eventoPanel.Margin = new Padding(10);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 150;
                    pictureBox.Height = 120;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    if (evento.Imagem != null)
                    {
                        pictureBox.Image = evento.Imagem;
                    }
                    else
                    {
                        pictureBox.Image = Properties.Resources.festival_de_musica;
                    }

                    pictureBox.Tag = evento;
                    pictureBox.Cursor = Cursors.Hand;

                    pictureBox.Click += (s, args) =>
                    {
                        var pic = s as PictureBox;
                        var eventoSelecionado = pic.Tag as Eventos;
                        TelaExibirEvento tela = new TelaExibirEvento(eventoSelecionado);
                        tela.Show();
                    };

                    Label nomeLabel = new Label();
                    nomeLabel.Text = evento.NomeEvento;
                    nomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    nomeLabel.Dock = DockStyle.Bottom;
                    nomeLabel.Font = new Font("Segoe UI", 14, FontStyle.Regular);

                    eventoPanel.Controls.Add(pictureBox);
                    eventoPanel.Controls.Add(nomeLabel);
                    flowPanelEventos.Controls.Add(eventoPanel);
                }

                if (eventosEncontrados.Count == 0)
                {
                    MessageBox.Show("Nenhum evento encontrado com esse nome.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}

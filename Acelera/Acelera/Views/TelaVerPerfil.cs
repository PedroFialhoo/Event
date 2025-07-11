﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class TelaVerPerfil : Form
    {
        private int id;
        public TelaVerPerfil(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void TelaVerPerfil_Load(object sender, EventArgs e)
        {

            var usuario = UsuarioRepository.ObterUsuarioPorId(id);

            cbEventos.SelectedIndex = 0;
            lblNome.Text = usuario.Nome;
            //lblIdade.Text = usuario.Idade.ToString();

            string telefoneFormatado = "";

            string numeros = new string(usuario.Telefone.Where(char.IsDigit).ToArray());
            if (numeros.Length == 11)
                telefoneFormatado = $"({numeros.Substring(0, 2)}) {numeros.Substring(2, 5)}-{numeros.Substring(7, 4)}";
            else
                telefoneFormatado = usuario.Telefone;
            lblTelefone.Text = telefoneFormatado;
            //lblCpf.Text = usuario.Cpf;
            lblCidade.Text = usuario.Cidade;
            lblEstado.Text = usuario.Estado;


            if (usuario.Imagem != null)
            {
                pictureBoxPerfil.Image = usuario.Imagem;
            }

            CarregarPagina();
        }

        private void CarregarPagina()
        {
            var usuario = UsuarioRepository.ObterUsuarioPorId(id);
            foreach (var evento in EventoRepository.BuscarEventosDoUsuario(usuario.Id))
            {
                var participante = evento.ParticipantesIds.FirstOrDefault(p => p.idParticipante == usuario.Id);
                Debug.WriteLine($"Evento: {evento.NomeEvento} | Participação: {participante?.participacao}");
            }

            flowPanelEventos.Controls.Clear();

            if (cbEventos.SelectedIndex == 0)
            {
                var eventosDoUsuario = EventoRepository.BuscarEventosDoUsuario(usuario.Id);

                foreach (var evento in eventosDoUsuario)
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
                        this.Close();
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
            }
            else
            {
                bool selo = false;
                if (cbEventos.SelectedIndex == 1)
                {
                    selo = false;
                }
                else if (cbEventos.SelectedIndex == 2)
                {
                    selo = true;
                }

                var eventosDoUsuario = EventoRepository.BuscarEventosDoUsuarioSelo(usuario.Id, selo);

                foreach (var evento in eventosDoUsuario)
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
                        this.Close();
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
            }

        }

        private void cbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPagina();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TelaComunidades tela = new TelaComunidades();
            tela.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apenas colaboradores podem criar eventos.\nDeseja se cadastrar como um colaborador?", "Atenção", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TelaCadastroColaborador telaCadastro = new TelaCadastroColaborador();
                telaCadastro.Show();
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos();
            telaBuscarEventos.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaComunidades telaComunidades = new TelaComunidades();
            telaComunidades.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }

        private void cbEventos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregarPagina();
        }
    }
}

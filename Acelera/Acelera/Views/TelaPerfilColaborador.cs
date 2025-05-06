using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Models;
using Acelera.Repositories;

namespace Acelera.Views
{
    public partial class TelaPerfilColaborador : Form
    {
        private Colaborador colaborador;
        private Eventos eventos;
        
        public TelaPerfilColaborador(Colaborador colaboradorLogado)
        {
            InitializeComponent();
            colaborador = colaboradorLogado;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCriarEvento telaCriarEvento = new TelaCriarEvento();
            telaCriarEvento.Show();

        }

        private void TelaPerfilColaborador_Load(object sender, EventArgs e)
        {
            var nomeColaborador = colaborador.Nome;

            lblNome.Text = nomeColaborador;
            lblTelefone.Text = colaborador.Telefone;
            lblNomeEmpresa.Text = colaborador.NomeEmpresa;

            if (colaborador.Imagem != null)
            {
                picturePerfil.Image = colaborador.Imagem;
            }

            var eventosDoColaborador = EventoRepository.ObterEventosPorColaborador(nomeColaborador);
            foreach (var evento in eventosDoColaborador)
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
                    pictureBox.Image = Properties.Resources.cara; 
                }

                pictureBox.Tag = evento;
                pictureBox.Cursor = Cursors.Hand; // mostra a "mão" ao passar o mouse

                // Adiciona o evento de clique
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

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            menuOpcoes.Show(btnMenu, new Point(0, btnMenu.Height));
        }
               

        private void menuItemDeslogar_Click_1(object sender, EventArgs e)
        {
            LoginColaboradorRepository.Sair();
            TelaLoginColaborador telaLogin = new TelaLoginColaborador();
            telaLogin.Show();
        }

        private void menuItemEditar_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginColaboradorRepository.GetUsuarioLogadoId();
            Colaborador colaboradorLogado = ColaboradorRepository.ObterColaboradorPorId(idUsuarioLogado.Value);
            TelaEditarPerfilColaborador telaEditarPerfilColaborador = new TelaEditarPerfilColaborador(colaboradorLogado);
            telaEditarPerfilColaborador.Show();
        }

        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult resultado =  MessageBox.Show("Deseja excluir a conta?\n Todos os dados serão exluídos permanentemente, incluindo os eventos relacionados à conta", "Excluir conta permanentemente!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}

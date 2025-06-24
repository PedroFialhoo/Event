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

namespace Acelera.Forms
{
    public partial class TelaPrincipal: Form
    {
        int? idUsuarioLogado = LoginRepository.GetUsuarioLogadoId();
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            

            if (idUsuarioLogado == null)
            {               
                DialogResult result = MessageBox.Show("Nenhum usuário está logado.\nDeseja se cadastrar?", "Atenção", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TelaCadastro telaCadastro = new TelaCadastro();
                    telaCadastro.Show();
                    this.Close();
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos();
            telaBuscarEventos.Show();
            this.Close();
        }

        private void btnEducacao_Click(object sender, EventArgs e)
        {
            string categoria = "Educação";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
            this.Close();
        }

        private void btnSaude_Click(object sender, EventArgs e)
        {
            string categoria = "Saúde";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
            this.Close();
        }

        private void btnEmpreendedorismo_Click(object sender, EventArgs e)
        {
            string categoria = "Empreendedorismo";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
            this.Close();
        }

        private void btnComputacao_Click(object sender, EventArgs e)
        {
            string categoria = "Computação";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
            this.Close();
        }

        private void btnEsportes_Click(object sender, EventArgs e)
        {
            string categoria = "Esportes";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
            this.Close();
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            string categoria = "Música";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
            this.Close();
        }

        private void btnOutros_Click(object sender, EventArgs e)
        {
            string categoria = "Outros";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idUsuarioLogado.HasValue)
            {
                TelaComunidades telaComunidades = new TelaComunidades();
                telaComunidades.Show();
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Nenhum usuário está logado.\nDeseja se cadastrar?","Atenção",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TelaCadastro telaCadastro = new TelaCadastro();
                    telaCadastro.Show();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apenas colaboradores podem criar eventos.\nDeseja se cadastrar como um colaborador?", "Atenção", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TelaCadastroColaborador telaCadastro = new TelaCadastroColaborador();
                telaCadastro.Show();
                this.Close();
            }
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            int? usuarioId = LoginRepository.GetUsuarioLogadoId();
            List<Eventos> eventosEncontrados;

            if (usuarioId != null)
            {
                var user = UsuarioRepository.ObterUsuarioPorId(usuarioId.Value);
                eventosEncontrados = EventoRepository.ObterEventosPorEstado(user.Estado);
            }
            else
            {
                MessageBox.Show("Você está acessando como visitante. Faça login para ver eventos da sua região.", "Visitante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                eventosEncontrados = EventoRepository.ListarEventos(); 
            }

            flowPanelEventos.Controls.Clear(); 

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

            if (eventosEncontrados.Count == 0)
            {
                MessageBox.Show("Nenhum evento encontrado na sua região.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    

}

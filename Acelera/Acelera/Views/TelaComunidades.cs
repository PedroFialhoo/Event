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
using Acelera.Controllers;
using Acelera.Forms;

namespace Acelera.Views
{
    public partial class TelaComunidades : Form
    {
        private string categoria = "computacao";

        private Image imagemSelecionada = null;

        public TelaComunidades()
        {
            InitializeComponent();

            // Associa eventos de mudança para cada opção
            opComputacao.CheckedChanged += Categoria_CheckedChanged;
            opEducacao.CheckedChanged += Categoria_CheckedChanged;
            opEmpreendedorismo.CheckedChanged += Categoria_CheckedChanged;
            opEsporte.CheckedChanged += Categoria_CheckedChanged;
            opMusica.CheckedChanged += Categoria_CheckedChanged;
            opSaude.CheckedChanged += Categoria_CheckedChanged;
        }

        private void TelaComunidades_Load(object sender, EventArgs e)
        {
            AtualizarPublicacoes();
        }

        private void Categoria_CheckedChanged(object sender, EventArgs e)
        {
            // Só atualiza se a opção foi marcada (Checked == true)
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                AtualizarPublicacoes();
            }
        }

        private void AtualizarPublicacoes()
        {
            if (opComputacao.Checked) categoria = "computacao";
            else if (opEducacao.Checked) categoria = "educacao";
            else if (opEmpreendedorismo.Checked) categoria = "empreendedorismo";
            else if (opEsporte.Checked) categoria = "esporte";
            else if (opMusica.Checked) categoria = "musica";
            else if (opSaude.Checked) categoria = "saude";

            Console.WriteLine($"Categoria selecionada: {categoria}");

            ComunidadeController comunidadeController = new ComunidadeController();
            var publicacoes = comunidadeController.ListarPublicacoes(categoria);
            Console.WriteLine($"Categoria: {categoria}, Publicações encontradas: {publicacoes.Count}");

            flowPanelComentarios.Controls.Clear();
            txtMensagem.Clear();

            foreach (var publicacao in publicacoes)
            {
                Panel comentarioPanel = new Panel();
                comentarioPanel.Width = 900;
                comentarioPanel.AutoSize = true;
                comentarioPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                comentarioPanel.MinimumSize = new Size(900, 100);
                comentarioPanel.Margin = new Padding(10);
                comentarioPanel.BorderStyle = BorderStyle.FixedSingle;  // Melhor visualizar limites
                comentarioPanel.Padding = new Padding(5);
                comentarioPanel.BackColor = Color.FromArgb(217, 238, 252);


                FlowLayoutPanel flowInterno = new FlowLayoutPanel();
                flowInterno.FlowDirection = FlowDirection.TopDown;
                flowInterno.WrapContents = false;
                flowInterno.AutoSize = true;
                flowInterno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                flowInterno.Dock = DockStyle.Fill;
                flowInterno.Padding = new Padding(0);
                flowInterno.Margin = new Padding(0);

                Label autorLabel = new Label();
                autorLabel.Text = $"{publicacao.Autor}";
                autorLabel.AutoSize = true;
                autorLabel.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                autorLabel.Margin = new Padding(0, 0, 0, 5);

                if (!string.IsNullOrEmpty(publicacao.ImagemBase64))
                {
                    PictureBox picture = new PictureBox();
                    picture.Image = publicacao.ObterImagem();
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Width = 850;
                    picture.Height = 300;
                    picture.Margin = new Padding(0, 0, 0, 5);
                    flowInterno.Controls.Add(picture);
                }

                Label mensagemLabel = new Label();
                mensagemLabel.Text = publicacao.Mensagem;
                mensagemLabel.MaximumSize = new Size(850, 0);  // quebra automática
                mensagemLabel.AutoSize = true;
                mensagemLabel.Font = new Font("Segoe UI", 15);
                mensagemLabel.Margin = new Padding(0, 0, 0, 5);

                Label dataLabel = new Label();
                dataLabel.Text = publicacao.Data.ToString("g");
                dataLabel.AutoSize = true;
                dataLabel.Font = new Font("Segoe UI", 10, FontStyle.Italic);

                // Adiciona na ordem correta
                flowInterno.Controls.Add(autorLabel);
                flowInterno.Controls.Add(mensagemLabel);
                flowInterno.Controls.Add(dataLabel);

                if (publicacao.SeloVou)
                {
                    Label seloVou = new Label();
                    seloVou.Text = "Selo: Eu Vou";
                    seloVou.AutoSize = true;
                    seloVou.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    seloVou.ForeColor = Color.DarkGreen;
                    seloVou.Margin = new Padding(0, 5, 0, 0);
                    flowInterno.Controls.Add(seloVou);
                }
                if (publicacao.SeloFui)
                {
                    Label seloFui = new Label();
                    seloFui.Text = "Selo: Eu Fui";
                    seloFui.AutoSize = true;
                    seloFui.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    seloFui.ForeColor = Color.DarkBlue;
                    seloFui.Margin = new Padding(0, 2, 0, 0);
                    flowInterno.Controls.Add(seloFui);
                }

                // Adiciona o Flow interno no painel
                comentarioPanel.Controls.Add(flowInterno);

                // Adiciona no FlowPanel principal
                flowPanelComentarios.Controls.Add(comentarioPanel);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opComputacao.Checked) categoria = "computacao";
            else if (opEducacao.Checked) categoria = "educacao";
            else if (opEmpreendedorismo.Checked) categoria = "empreendedorismo";
            else if (opEsporte.Checked) categoria = "esporte";
            else if (opMusica.Checked) categoria = "musica";
            else if (opSaude.Checked) categoria = "saude";

            int? id = LoginRepository.GetUsuarioLogadoId();
            var u = UsuarioRepository.ObterUsuarioPorId(id.Value);

            

            Publicacao publicacao = new Publicacao
            {
                Autor = u.Nome,
                Mensagem = txtMensagem.Text,
                Data = DateTime.Now,
                ImagemBase64 = imagemSelecionada != null ? Publicacao.ConverterImagem(imagemSelecionada) : null
            };

            ComunidadeRepository comunidadeRepository = new ComunidadeRepository();
            comunidadeRepository.AdicionarPublicacao(categoria, publicacao);
            AtualizarPublicacoes();

           /* DialogResult dialog = MessageBox.Show(
                "Como você deseja marcar este evento?\n\nSim: Evento futuro (Eu Vou)\nNão: Evento passado (Eu Fui)\nCancelar: Nenhum selo",
                "Selo do evento",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );
            if ( dialog == DialogResult.Yes)
            {
                publicacao.SeloVou = true;
            } else if ( dialog == DialogResult.No)
            {
                publicacao.SeloFui = true;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos();
            telaBuscarEventos.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagemSelecionada = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick(); // Aciona o clique do botão
                e.Handled = true;
                e.SuppressKeyPress = true; // Impede o "beep" do Enter
            }
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var user = UsuarioRepository.ObterUsuarioPorId(LoginRepository.GetUsuarioLogadoId().Value);
            if (user != null)
            {
                TelaPerfil telaPerfil = new TelaPerfil(user);
                telaPerfil.Show();
                this.Close();
            }
        }
    }
}



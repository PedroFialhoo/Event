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

namespace Acelera.Views
{
    public partial class TelaComunidades : Form
    {
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

            string categoria = "computacao";

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

            foreach (var publicacao in publicacoes)
            {
                Panel comentarioPanel = new Panel();
                comentarioPanel.Width = 300;
                comentarioPanel.Height = 100;
                comentarioPanel.Margin = new Padding(10);
                comentarioPanel.BorderStyle = BorderStyle.FixedSingle;

                Label autorLabel = new Label();
                autorLabel.Text = $"Autor: {publicacao.Autor}";
                autorLabel.Dock = DockStyle.Top;
                autorLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                Label mensagemLabel = new Label();
                mensagemLabel.Text = publicacao.Mensagem;
                mensagemLabel.Dock = DockStyle.Fill;
                mensagemLabel.Font = new Font("Segoe UI", 10);
                mensagemLabel.AutoSize = false;
                mensagemLabel.TextAlign = ContentAlignment.MiddleLeft;

                Label dataLabel = new Label();
                dataLabel.Text = publicacao.Data.ToString("g");
                dataLabel.Dock = DockStyle.Bottom;
                dataLabel.Font = new Font("Segoe UI", 8, FontStyle.Italic);

                comentarioPanel.Controls.Add(autorLabel);
                comentarioPanel.Controls.Add(mensagemLabel);
                comentarioPanel.Controls.Add(dataLabel);

                flowPanelComentarios.Controls.Add(comentarioPanel);
            }

            if (publicacoes.Count == 0)
            {
                MessageBox.Show("Nenhuma publicação encontrada nesta comunidade.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}



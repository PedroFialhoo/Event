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
    public partial class TelaParticipantes : Form
    {
        private Eventos evento;
        public TelaParticipantes(Eventos evento)
        {
            InitializeComponent();
            this.evento = evento;
        }

        private void TelaParticipantes_Load(object sender, EventArgs e)
        {
            flowPanelParticipantes.Controls.Clear();

            var participantes = EventoRepository.ListarParticipantes(evento.Id);

            // Cabeçalho
            Panel header = new Panel();
            header.Size = new Size(1720, 50);
            header.BackColor = Color.LightGray;

            header.Controls.Add(new Label
            {
                Text = "Nome",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(20, 15),
                AutoSize = true
            });

            header.Controls.Add(new Label
            {
                Text = "Telefone",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(400, 15),
                AutoSize = true
            });

            header.Controls.Add(new Label
            {
                Text = "Código",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(800, 15),
                AutoSize = true
            });

            header.Controls.Add(new Label
            {
                Text = "Ação",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(1300, 15),
                AutoSize = true
            });

            flowPanelParticipantes.Controls.Add(header);

            bool alternar = false;

            foreach (var participante in participantes)
            {
                var user = UsuarioRepository.ObterUsuarioPorId(participante.idParticipante);

                Panel panel = new Panel();
                panel.Size = new Size(1720, 60);
                panel.BackColor = alternar ? Color.White : Color.Gainsboro;
                alternar = !alternar;

                Label lblNome = new Label
                {
                    Text = user.Nome,
                    Location = new Point(20, 20),
                    Font = new Font("Segoe UI", 11),
                    AutoSize = true
                };

                string telefoneFormatado = "";

                string numeros = new string(user.Telefone.Where(char.IsDigit).ToArray());
                if (numeros.Length == 11)
                    telefoneFormatado = $"({numeros.Substring(0, 2)}) {numeros.Substring(2, 5)}-{numeros.Substring(7, 4)}";
                else
                    telefoneFormatado = user.Telefone;

                Label lblTelefone = new Label
                {
                    Text = telefoneFormatado,
                    Location = new Point(400, 20),
                    Font = new Font("Segoe UI", 11),
                    AutoSize = true
                };

                Label lblCodigo = new Label
                {
                    Text = participante.codeParticipante,
                    Location = new Point(800, 20),
                    Font = new Font("Segoe UI", 11),
                    AutoSize = true
                };

                Button btnAcao = new Button
                {
                    Size = new Size(220, 30),
                    Location = new Point(1250, 15),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Tag = participante,
                    FlatStyle = FlatStyle.Flat
                };

                if (!participante.participacao)
                {
                    btnAcao.Text = "Confirmar Participação";
                    btnAcao.BackColor = Color.ForestGreen;
                    btnAcao.ForeColor = Color.White;
                }
                else
                {
                    btnAcao.Text = "Remover Participação";
                    btnAcao.BackColor = Color.IndianRed;
                    btnAcao.ForeColor = Color.White;
                }

                btnAcao.Click += (s, args) =>
                {
                    var p = (ListaParticipantes)((Button)s).Tag;

                    if (p.participacao)
                    {
                        EventoRepository.RetirarParticipacao(evento.Id, p.idParticipante);
                        var u = UsuarioRepository.ObterUsuarioPorId(p.idParticipante);
                        MessageBox.Show($"{u.Nome} removido da participação.");
                    }
                    else
                    {
                        EventoRepository.ConfirmarParticipacao(evento.Id, p.idParticipante);
                        var u = UsuarioRepository.ObterUsuarioPorId(p.idParticipante);
                        MessageBox.Show($"{u.Nome} confirmado como participante.");
                    }

                    TelaParticipantes_Load(null, null);
                };

                panel.Controls.Add(lblNome);
                panel.Controls.Add(lblTelefone);
                panel.Controls.Add(lblCodigo);
                panel.Controls.Add(btnAcao);

                flowPanelParticipantes.Controls.Add(panel);
            }
        }


        private void flowPanelEventos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaExibirEventoColaborador telaExibirEventoColaborador = new TelaExibirEventoColaborador(evento);
            telaExibirEventoColaborador.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = LoginColaboradorRepository.GetUsuarioLogadoId();
            var colaborador = ColaboradorRepository.ObterColaboradorPorId(id.Value);
            TelaPerfilColaborador telaPerfilColaborador = new TelaPerfilColaborador(colaborador);
            telaPerfilColaborador.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = LoginColaboradorRepository.GetUsuarioLogadoId();
            var colaborador = ColaboradorRepository.ObterColaboradorPorId(id.Value);
            TelaPerfilColaborador telaPerfilColaborador = new TelaPerfilColaborador(colaborador);
            telaPerfilColaborador.Show();
            this.Close();
        }
    }
}

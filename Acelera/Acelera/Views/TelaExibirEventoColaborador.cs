using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Models;
using Acelera.Repositories;

namespace Acelera.Views
{
    public partial class TelaExibirEventoColaborador : Form
    {
        private Eventos evento;
        public TelaExibirEventoColaborador(Eventos eventoSelecionado)
        {
            InitializeComponent();
            evento = eventoSelecionado;
        }

        private void TelaExibirEventoColaborador_Load(object sender, EventArgs e)
        {
            lblNome.Text = evento.NomeEvento;
            lblRua.Text = evento.Rua;
            lblNumero.Text = evento.Numero;
            lblHorario.Text = evento.Horario;
            lblEstado.Text = evento.Estado;
            lblCidade.Text = evento.Cidade;
            lblData.Text = evento.Data.ToString("dd/MM/yyyy");
            lblTipo.Text = evento.Tipo;
            txtDescricao.Text = evento.Descricao;
            pictureEvento.Image = evento.Imagem;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? idColaboradorLogado = LoginColaboradorRepository.GetUsuarioLogadoId();
            if (idColaboradorLogado == null)
            {
                MessageBox.Show("Apenas Colaboradores podem editar eventos");
                return;
            }

            TelaEditarEvento telaEditarEvento = new TelaEditarEvento(evento);
            telaEditarEvento.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int? idColaboradorLogado = LoginColaboradorRepository.GetUsuarioLogadoId();
            if (idColaboradorLogado == null)
            {
                MessageBox.Show("Apenas Colaboradores podem editar eventos");
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja exluir permanentemente o evento?", "Excluir evento!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                int idEvento = evento.Id;
                bool sucesso = EventoRepository.RemoverEvento(idEvento);
                if (sucesso)
                {
                    MessageBox.Show("Evento deletado com sucesso");

                    if (idColaboradorLogado != null)
                    {
                        Colaborador colaboradorLogado = ColaboradorRepository.ObterColaboradorPorId(idColaboradorLogado.Value);
                        if (colaboradorLogado != null)
                        {
                            TelaPerfilColaborador telaPerfil = new TelaPerfilColaborador(colaboradorLogado);
                            telaPerfil.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Perfil de colaborador não encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir evento");
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = LoginColaboradorRepository.GetUsuarioLogadoId();
            var colaborador = ColaboradorRepository.ObterColaboradorPorId(id.Value);
            TelaPerfilColaborador telaPerfilColaborador = new TelaPerfilColaborador(colaborador);
            telaPerfilColaborador.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaParticipantes telaParticipantes = new TelaParticipantes(evento);
            telaParticipantes.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int? id = LoginColaboradorRepository.GetUsuarioLogadoId();
            var colaborador = ColaboradorRepository.ObterColaboradorPorId(id.Value);
            TelaPerfilColaborador telaPerfilColaborador = new TelaPerfilColaborador(colaborador);
            telaPerfilColaborador.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int? id = LoginColaboradorRepository.GetUsuarioLogadoId();
            var colaborador = ColaboradorRepository.ObterColaboradorPorId(id.Value);
            TelaPerfilColaborador telaPerfilColaborador = new TelaPerfilColaborador(colaborador);
            telaPerfilColaborador.Show();
            this.Close();
        }
    }
}

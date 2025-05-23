﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class TelaExibirEvento : Form
    {
        private Eventos evento;
        public TelaExibirEvento(Eventos eventoSelecionado)
        {
            InitializeComponent();
            evento = eventoSelecionado;
        }

        private void TelaExibirEvento_Load(object sender, EventArgs e)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuOpcoes.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void menuItemEditar_Click(object sender, EventArgs e)
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

        private void fecharEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? idColaboradorLogado = LoginColaboradorRepository.GetUsuarioLogadoId();

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
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show();
                this.Close();
            }
        }

        private void excluirEventoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int? usuarioLogado = LoginRepository.GetUsuarioLogadoId();

            if (usuarioLogado == null)
            {
                DialogResult resultado = MessageBox.Show("Colaboradores não podem participar de eventos. Deseja fazer login como usuário?","Acesso Negado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LoginColaboradorRepository.Sair();
                    TelaLogin telaLogin = new TelaLogin();
                    telaLogin.Show();
                    this.Close();
                }
                return;
            }

            if(EventoRepository.ParticiparDoEvento(evento.Id, usuarioLogado.Value))
            {
                MessageBox.Show("Você está participando deste evento!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você já está participando deste evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? idColaboradorLogado = LoginColaboradorRepository.GetUsuarioLogadoId();

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
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? usuarioLogado = LoginRepository.GetUsuarioLogadoId();
            if(usuarioLogado == null)
            {
                DialogResult resultado = MessageBox.Show("Colaboradores não podem participar de eventos. Deseja fazer login como usuário?", "Acesso Negado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LoginColaboradorRepository.Sair();
                    TelaLogin telaLogin = new TelaLogin();
                    telaLogin.Show();
                    this.Close();                    
                }
                return;
            }
            if (EventoRepository.DesinscreverDoEvento(evento.Id, usuarioLogado.Value))
            {
                MessageBox.Show("Participação do evento removida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você já não está participando deste evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera.Controllers;
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
            CarregarPagina();            
        }

        private void CarregarPagina()
        {
            if (evento == null)
            {
                System.Diagnostics.Debug.WriteLine("Evento não inicializado!");
                return;
            }

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

            buttonLink.Visible = evento.Online;

            int? id = LoginRepository.GetUsuarioLogadoId();
            if (id == null)
            {
                System.Diagnostics.Debug.WriteLine("Usuário não está logado!");
                return;
            }

            string codigo = EventoRepository.ObterCodigoParticipante(evento.Id, id.Value);
            if (string.IsNullOrEmpty(codigo))
            {
                bQr.Visible = false;
                lQr.Visible = false;   
                panel1.Visible = false;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Código: {codigo}");
            }
            var participante = evento.ParticipantesIds.FirstOrDefault(p => p.idParticipante == id);
            if (participante == null || !participante.participacao)
            {
                bCert.Visible = false;
                lCert.Visible = false;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Participante válido: {participante.idParticipante} com participação: {participante.participacao}");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
        }

        private void menuItemEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void fecharEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void excluirEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                evento = EventoRepository.ObterEventoPorId(evento.Id);
                TelaExibirEvento telaExibirEvento = new TelaExibirEvento(evento);
                telaExibirEvento.Show();
                this.Close();
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
                evento = EventoRepository.ObterEventoPorId(evento.Id);
                TelaExibirEvento telaExibirEvento = new TelaExibirEvento(evento);
                telaExibirEvento.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Você já não está participando deste evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int? id = LoginRepository.GetUsuarioLogadoId().Value;
            string codigo = EventoRepository.ObterCodigoParticipante(evento.Id, id.Value);
            if (codigo != null)
            {
                TelaQrCode telaQrCode = new TelaQrCode(codigo);
                telaQrCode.Show();
            }
            else
            {
                MessageBox.Show("Você não está participando deste evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int? id = LoginRepository.GetUsuarioLogadoId();
            var user = UsuarioRepository.ObterUsuarioPorId(id.Value);
            TelaPerfil telaPerfil = new TelaPerfil(user);
            telaPerfil.Show();
            this.Close();
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            TelaLink telaLink = new TelaLink(evento);
            telaLink.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int? id = LoginRepository.GetUsuarioLogadoId();
            var user = UsuarioRepository.ObterUsuarioPorId(id.Value);
            CertificateController.GerarCertificado(user, evento);
        }
    }
}


using System;
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
    public partial class TelaEditarPerfilColaborador : Form
    {
        private Colaborador colaborador;
        public TelaEditarPerfilColaborador(Colaborador colaboradorLogado)
        {
            InitializeComponent();
            colaborador = colaboradorLogado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturePerfil.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginColaboradorRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Erro: Nenhum usuário está logado.");
                return;
            }

            Colaborador colaborador = new Colaborador
            {
                Nome = txtNome.Text,
                NomeEmpresa = txtNomeEmpresa.Text,
                Telefone = txtTelefone.Text,
                Imagem = picturePerfil.Image

            };

            bool sucesso = ColaboradorRepository.AtualizarColaborador(idUsuarioLogado.Value, colaborador);

            if (sucesso)
            {
                MessageBox.Show("Perfil Atualizado com sucesso!");
                TelaPerfilColaborador telaPerfil = new TelaPerfilColaborador(colaborador);
                telaPerfil.Show();
            }
            else
            {
                MessageBox.Show("Já existe um perfil para esse usuário.");
            }
        }

        private void TelaEditarPerfilColaborador_Load(object sender, EventArgs e)
        {
            txtNome.Text = colaborador.Nome;
            txtTelefone.Text = colaborador.Telefone;
            txtNomeEmpresa.Text = colaborador.NomeEmpresa;

            if (colaborador.Imagem != null)
            {
                picturePerfil.Image = colaborador.Imagem;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginColaboradorRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário está logado.");
                return;
            }

            Colaborador colaboradorLogado = ColaboradorRepository.ObterColaboradorPorId(idUsuarioLogado.Value);

            if (colaboradorLogado != null)
            {
                TelaPerfilColaborador telaPerfil = new TelaPerfilColaborador(colaboradorLogado);
                telaPerfil.Show();
            }
            else
            {
                MessageBox.Show("Perfil não encontrado.");
            }
        }
    }
    }


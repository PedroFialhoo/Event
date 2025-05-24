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
        }
    }
}

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

namespace Acelera.Forms
{
    public partial class TelaPerfil: Form
    {
        private Usuario usuario;
        public TelaPerfil(Usuario usuarioLogado)
        {
            InitializeComponent();
            usuario = usuarioLogado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            lblNome.Text = usuario.Nome;
            lblIdade.Text = usuario.Idade.ToString();
            lblTelefone.Text = usuario.Telefone;
            lblCpf.Text = usuario.Cpf;
            lblCidade.Text = usuario.Cidade;
            lblEstado.Text = usuario.Estado;

            if (usuario.Imagem != null)
            {
                pictureBoxPerfil.Image = usuario.Imagem;
            }
        }
    }
}

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

namespace Acelera.Forms
{
    public partial class TelaPrincipal: Form
    {

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? idUsuarioLogado = LoginRepository.GetUsuarioLogadoId();

            if (idUsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário está logado.");
                return;
            }

            // Busca o usuário no repositório usando o ID
            Usuario usuarioLogado = UsuarioRepository.ObterUsuarioPorId(idUsuarioLogado.Value);

            if (usuarioLogado != null)
            {
                // Cria e abre a TelaPerfil com o usuário logado
                TelaPerfil telaPerfil = new TelaPerfil(usuarioLogado);
                telaPerfil.Show();
            }
            else
            {
                MessageBox.Show("Perfil não encontrado.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera.Forms
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {          
            if (!string.IsNullOrWhiteSpace(campoEmail.Text) && !string.IsNullOrWhiteSpace(campoRepetirSenha.Text) &&
        !string.IsNullOrWhiteSpace(campoSenha.Text))
            {
                TelaCriarPerfil telaCriarPerfil = new TelaCriarPerfil();
                telaCriarPerfil.WindowState = FormWindowState.Maximized;
                telaCriarPerfil.Show();
                this.Hide();
                telaCriarPerfil.FormClosed += (s, args) => this.Close();
            }
            else
            {                
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

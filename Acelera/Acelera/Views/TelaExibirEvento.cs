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
            lblLocal.Text = evento.Local;
            lblHorario.Text = evento.Horario;
            lblEstado.Text = evento.Estado;
            lblCidade.Text = evento.Cidade;
            lblData.Text = evento.Data.ToString("dd/MM/yyyy");
            lblTipo.Text = evento.Tipo;
            txtDescricao.Text = evento.Descricao;
            pictureEvento.Image = evento.Imagem;

        }
    }
}

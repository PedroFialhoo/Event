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
    public partial class TelaPerfilColaborador : Form
    {
        private Colaborador colaborador;
        public TelaPerfilColaborador(Colaborador colaboradorLogado)
        {
            InitializeComponent();
            colaborador = colaboradorLogado;
        }
    }
}

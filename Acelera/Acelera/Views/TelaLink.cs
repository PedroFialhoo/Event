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
    public partial class TelaLink : Form
    {
        private Eventos evento;
        public TelaLink(Eventos evento)
        {
            InitializeComponent();
            this.evento = evento;
        }

        private void TelaLink_Load(object sender, EventArgs e)
        {
            txtLink.Text = evento.Link;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

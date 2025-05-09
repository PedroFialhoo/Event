﻿using System;
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

        private void button3_Click(object sender, EventArgs e)
        {
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos();
            telaBuscarEventos.Show();
        }

        private void btnEducacao_Click(object sender, EventArgs e)
        {
            string categoria = "Educação";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
        }

        private void btnSaude_Click(object sender, EventArgs e)
        {
            string categoria = "Saúde";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
        }

        private void btnEmpreendedorismo_Click(object sender, EventArgs e)
        {
            string categoria = "Empreendedorismo";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
        }

        private void btnComputacao_Click(object sender, EventArgs e)
        {
            string categoria = "Computação";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
        }

        private void btnEsportes_Click(object sender, EventArgs e)
        {
            string categoria = "Esportes";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            string categoria = "Música";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
        }

        private void btnOutros_Click(object sender, EventArgs e)
        {
            string categoria = "Outros";
            TelaBuscarEventos telaBuscarEventos = new TelaBuscarEventos(categoria);
            telaBuscarEventos.Show();
        }
    }
}

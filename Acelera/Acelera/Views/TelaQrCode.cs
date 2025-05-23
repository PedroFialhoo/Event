using Acelera.Forms;
using Acelera.Repositories;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera.Views
{
    public partial class TelaQrCode : Form
    {
        private int? idLogado = LoginRepository.GetUsuarioLogadoId();
        
        public TelaQrCode()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (idLogado.HasValue)
            {
                var login = LoginRepository.ListarTodos().FirstOrDefault(l => l.Id == idLogado.Value);

                if (login != null && !string.IsNullOrEmpty(login.CodeQR))
                {
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(login.CodeQR, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    Box_QrCode.Image = qrCodeImage;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuario = UsuarioRepository.ObterUsuarioPorId(idLogado.Value);

            TelaPerfil telaPerfil = new TelaPerfil(usuario);
            telaPerfil.Show();
            this.Close();
        }
    }
}

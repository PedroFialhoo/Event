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
using QRCoder;


namespace Acelera.Views
{
    public partial class TelaQrCode : Form
    {
        int? idLogado = LoginRepository.GetUsuarioLogadoId();
        public TelaQrCode()
        {
            InitializeComponent();
        }

        private void TelaQrCode_Load(object sender, EventArgs e)
        {
            if (idLogado.HasValue)
            {
                var login = LoginRepository.ListarTodos().FirstOrDefault(l => l.Id == idLogado.Value);

                if (login != null && !string.IsNullOrEmpty(login.CodeQR))
                {
                    Usuario u = UsuarioRepository.ObterUsuarioPorId(idLogado.Value);
                    string cpf = u.Cpf;

                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(cpf, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(30);
                    pictureBox1.Image = qrCodeImage;


                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

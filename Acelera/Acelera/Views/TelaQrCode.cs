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
        private string code;
        public TelaQrCode(string code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void TelaQrCode_Load(object sender, EventArgs e)
        {

             QRCodeGenerator qrGenerator = new QRCodeGenerator();
             QRCodeData qrCodeData = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
             QRCode qrCode = new QRCode(qrCodeData);
             Bitmap qrCodeImage = qrCode.GetGraphic(30);
             pictureBox1.Image = qrCodeImage;               
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

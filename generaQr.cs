using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using QRCodeGenerator = QRCoder.QRCodeGenerator;

namespace QR_Generator
{
    public partial class generaQr : Form
    {
        public generaQr()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string contenido = txtContenido.Text;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(50);

            pictureQR.SizeMode = PictureBoxSizeMode.Zoom;
            pictureQR.Image = qrCodeImage;
        }

        private void btnSaveSVG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivos SVG|*.svg";
            saveDialog.Title = "Guardar como SVG";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(txtContenido.Text, QRCodeGenerator.ECCLevel.Q);
                    SvgQRCode qrCode = new SvgQRCode(qrCodeData);
                    writer.Write(qrCode.GetGraphic(20));
                }
            }

            MessageBox.Show("Su código en formato SVG se guardó exitosamente","NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSavePNG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivos PNG|*.png";
            saveDialog.Title = "Guardar como PNG";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;

                pictureQR.Image.Save(filePath, ImageFormat.Png);
            }

            MessageBox.Show("Su código en formato PNG se guardó exitosamente", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por: Luis Palacios\nFecha: 05/10/2023\nCorreo: LPALACIOS1119@GMAIL.COM");
        }

        private void btnRecortaUrl_Click(object sender, EventArgs e)
        {
            recortaUrl oRecortaUrl = new recortaUrl();
            oRecortaUrl.Show();
        }
    }
}
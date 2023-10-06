using RestSharp;
using System.IO;
using System.Net;
using System;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator.ShadowSocksConfig;

namespace QR_Generator
{
    public partial class recortaUrl : Form
    {
        public recortaUrl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string longUrl = txtTextoLargo.Text;
            string shortenedUrl = ShortenUrlWithTinyURL(longUrl);
            txtTextoCorto.Text = shortenedUrl;
        }

        private string ShortenUrlWithTinyURL(string longUrl)
        {
            try
            {
                string apiUrl = $"http://tinyurl.com/api-create.php?url={Uri.EscapeUriString(longUrl)}";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al acortar la URL. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
    }
}
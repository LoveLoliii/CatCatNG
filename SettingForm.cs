using System.Net;
using WebP.Net;

namespace WinFormsApp2
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String webpImageUrl = "https://i0.hdslb.com/bfs/new_dyn/750c0c53bbee5e1d4f151b3ac7236bd21999280.png@180w_180h_1e_1c.webp";

            using (WebClient webClient = new WebClient())
            {
                byte[] webpData = webClient.DownloadData(webpImageUrl);

                using (MemoryStream stream = new MemoryStream(webpData))
                {
                    // ʹ�� LibwebpSharp ������ WebP ͼ��
                    

                    // �� WebP ͼ��ת��Ϊ Bitmap
                    Bitmap bitmap = WebPDecoder.Decode(webpData);

                    int buttonWidth = 145;
                    int buttonHeight = 145;
                    Image scaledImage = new Bitmap(buttonWidth, buttonHeight);

                    using (Graphics graphics = Graphics.FromImage(scaledImage))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(bitmap, new Rectangle(0, 0, buttonWidth, buttonHeight), new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
                    }

                    // ���� PictureBox ��ͼ��
                    pictureBox1.Image = scaledImage;
                }
            }
            Console.WriteLine("load from");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanmuForm newForm = new();

            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // ִ�г����Ӳ����������һ������
                System.Diagnostics.Process.Start("cmd","/c start https://www.bilibili.com");
            }
            catch (Exception ex)
            {
                // �����쳣��������ʾ������Ϣ
                MessageBox.Show("�޷������ӣ�" + ex.Message);
            }
        }
    }
}
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
                    // 使用 LibwebpSharp 来解码 WebP 图像
                    

                    // 将 WebP 图像转换为 Bitmap
                    Bitmap bitmap = WebPDecoder.Decode(webpData);

                    int buttonWidth = 145;
                    int buttonHeight = 145;
                    Image scaledImage = new Bitmap(buttonWidth, buttonHeight);

                    using (Graphics graphics = Graphics.FromImage(scaledImage))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(bitmap, new Rectangle(0, 0, buttonWidth, buttonHeight), new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
                    }

                    // 设置 PictureBox 的图像
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
                // 执行超链接操作，例如打开一个链接
                System.Diagnostics.Process.Start("cmd","/c start https://www.bilibili.com");
            }
            catch (Exception ex)
            {
                // 处理异常，例如显示错误消息
                MessageBox.Show("无法打开链接：" + ex.Message);
            }
        }
    }
}
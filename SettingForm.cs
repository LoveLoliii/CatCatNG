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
            Console.WriteLine("load from");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanmuForm newForm = new();

            newForm.Show();
        }
    }
}
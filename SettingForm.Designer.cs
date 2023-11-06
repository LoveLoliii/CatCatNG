namespace WinFormsApp2
{
    partial class SettingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startDanmuFormBtn = new Button();
            pictureBox1 = new PictureBox();
            blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startDanmuFormBtn
            // 
            startDanmuFormBtn.FlatAppearance.BorderSize = 0;
            startDanmuFormBtn.FlatStyle = FlatStyle.Flat;
            startDanmuFormBtn.Image = CatCatNG.Properties.Resources.play1;
            startDanmuFormBtn.Location = new Point(39, 464);
            startDanmuFormBtn.Margin = new Padding(72, 33, 72, 33);
            startDanmuFormBtn.Name = "startDanmuFormBtn";
            startDanmuFormBtn.Size = new Size(46, 46);
            startDanmuFormBtn.TabIndex = 0;
            startDanmuFormBtn.UseVisualStyleBackColor = true;
            startDanmuFormBtn.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 20);
            pictureBox1.Margin = new Padding(72, 33, 72, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 144);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // blazorWebView1
            // 
            blazorWebView1.Dock = DockStyle.Fill;
            blazorWebView1.Location = new Point(0, 0);
            blazorWebView1.Name = "blazorWebView1";
            blazorWebView1.Size = new Size(917, 773);
            blazorWebView1.TabIndex = 2;
            blazorWebView1.Text = "blazorWebView1";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(917, 773);
            Controls.Add(blazorWebView1);
            Controls.Add(pictureBox1);
            Controls.Add(startDanmuFormBtn);
            Margin = new Padding(72, 33, 72, 33);
            Name = "SettingForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startDanmuFormBtn;
        private PictureBox pictureBox1;
        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
    }
}
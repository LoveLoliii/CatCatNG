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

        Image originPlayBtnImg = new Bitmap("E:\\git\\WinFormsApp2\\icon\\play.png");

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startDanmuFormBtn = new Button();
            SuspendLayout();
            // 
            // startDanmuFormBtn
            // 
            startDanmuFormBtn.Location = new Point(12, 211);
            startDanmuFormBtn.Name = "button1";
            startDanmuFormBtn.Size = new Size(35, 35);

            int playBtnWidth = startDanmuFormBtn.Width;
            int playBtnHeight = startDanmuFormBtn.Height;

            Image scalePlayBtnImg = new Bitmap(playBtnWidth, playBtnHeight);

            using (Graphics graphics = Graphics.FromImage(scalePlayBtnImg)) {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originPlayBtnImg, new Rectangle(0, 0, playBtnWidth, playBtnHeight), new Rectangle(0, 0, originPlayBtnImg.Width, originPlayBtnImg.Height), GraphicsUnit.Pixel);
            }

            startDanmuFormBtn.TabIndex = 0;
            startDanmuFormBtn.Text = "";
            startDanmuFormBtn.UseVisualStyleBackColor = true;
            startDanmuFormBtn.FlatStyle = FlatStyle.Flat;
            startDanmuFormBtn.FlatAppearance.BorderSize = 0;

            startDanmuFormBtn.Image = scalePlayBtnImg;
            startDanmuFormBtn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 700);
            Controls.Add(startDanmuFormBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startDanmuFormBtn;

    }
}
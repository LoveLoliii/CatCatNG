namespace WinFormsApp2
{
    partial class DanmuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(-2, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(778, 433);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DanmuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 431);
            Controls.Add(listView1);
            Name = "DanmuForm";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
    }
}
namespace AffinityWinFormsG8App
{
    partial class AffinityMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffinityMainForm));
            splitContainer1 = new SplitContainer();
            mainBannerPictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainBannerPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(mainBannerPictureBox1);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(948, 605);
            splitContainer1.SplitterDistance = 126;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // mainBannerPictureBox1
            // 
            mainBannerPictureBox1.Image = Properties.Resources.Affinity_VR_Logo__1_1;
            mainBannerPictureBox1.ImageLocation = "";
            mainBannerPictureBox1.Location = new Point(3, 0);
            mainBannerPictureBox1.Name = "mainBannerPictureBox1";
            mainBannerPictureBox1.Size = new Size(814, 500);
            mainBannerPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            mainBannerPictureBox1.TabIndex = 1;
            mainBannerPictureBox1.TabStop = false;
            mainBannerPictureBox1.WaitOnLoad = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 0;
            button1.Text = "Enter Oculus";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 506);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 34);
            textBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(518, 506);
            button2.Name = "button2";
            button2.Size = new Size(108, 34);
            button2.TabIndex = 2;
            button2.Text = "Submit Chat";
            button2.UseVisualStyleBackColor = true;
            // 
            // AffinityMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(948, 605);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AffinityMainForm";
            Text = "Welcome to Affinity! ";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainBannerPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private TextBox textBox1;
        private PictureBox mainBannerPictureBox1;
        private Button button2;
    }
}
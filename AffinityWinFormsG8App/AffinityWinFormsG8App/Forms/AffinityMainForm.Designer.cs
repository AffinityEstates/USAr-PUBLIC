﻿namespace AffinityWinFormsG8App
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
            tbApi = new TextBox();
            pictureBox1 = new PictureBox();
            tbChatOutput = new TextBox();
            lblChatResponse = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            mainBannerPictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainBannerPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.Affinity_VR_Logo__1_;
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(tbApi);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(tbChatOutput);
            splitContainer1.Panel1.Controls.Add(lblChatResponse);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(mainBannerPictureBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(952, 505);
            splitContainer1.SplitterDistance = 199;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // tbApi
            // 
            tbApi.Location = new Point(60, 99);
            tbApi.Name = "tbApi";
            tbApi.Size = new Size(110, 27);
            tbApi.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.chatgpt_logo_header_banner_345686558;
            pictureBox1.Location = new Point(12, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tbChatOutput
            // 
            tbChatOutput.BorderStyle = BorderStyle.FixedSingle;
            tbChatOutput.Cursor = Cursors.PanNW;
            tbChatOutput.Enabled = false;
            tbChatOutput.Font = new Font("Segoe UI Variable Text", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbChatOutput.Location = new Point(3, 335);
            tbChatOutput.Multiline = true;
            tbChatOutput.Name = "tbChatOutput";
            tbChatOutput.Size = new Size(193, 147);
            tbChatOutput.TabIndex = 5;
            // 
            // lblChatResponse
            // 
            lblChatResponse.AutoSize = true;
            lblChatResponse.Location = new Point(2, 359);
            lblChatResponse.Name = "lblChatResponse";
            lblChatResponse.Size = new Size(0, 20);
            lblChatResponse.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(12, 57);
            button3.Name = "button3";
            button3.Size = new Size(109, 29);
            button3.TabIndex = 3;
            button3.Text = "Roblox";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 217);
            button2.Name = "button2";
            button2.Size = new Size(118, 34);
            button2.TabIndex = 2;
            button2.Text = "Submit Chat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Affinity_World_Thumbnail;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.PanNW;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 0;
            button1.Text = "Enter Oculus";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 155);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 56);
            textBox1.TabIndex = 0;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key_icon_png_20_2507228831;
            pictureBox2.Location = new Point(12, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // AffinityMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            BackgroundImage = Properties.Resources.Affinity_VR_Logo__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(952, 505);
            Controls.Add(splitContainer1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AffinityMainForm";
            Text = "Welcome to Affinity! ";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainBannerPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private TextBox textBox1;
        private PictureBox mainBannerPictureBox1;
        private Button button2;
        private Button button3;
        private Label lblChatResponse;
        private PictureBox pictureBox1;
        private TextBox tbChatOutput;
        private TextBox tbApi;
        private PictureBox pictureBox2;
    }
}
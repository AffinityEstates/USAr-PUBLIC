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
            btnNewsPictureButton = new Button();
            label1 = new Label();
            btnIllinoiis = new Button();
            pictureBox3 = new PictureBox();
            cbChatCategory = new ComboBox();
            checkBox1 = new CheckBox();
            dbAIInput1 = new CheckBox();
            btnMich = new Button();
            lblChatResponse = new Label();
            btnKy = new Button();
            button3 = new Button();
            button1 = new Button();
            cbIsBotMuted = new CheckBox();
            panel1 = new Panel();
            btnGotoAdmin = new Button();
            btnLockedTab = new Button();
            tbApi = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tbChatOutput = new TextBox();
            mainBannerPictureBox1 = new PictureBox();
            btnTenn = new Button();
            tbChatInput = new TextBox();
            btnSubmitTextToBot = new Button();
            btnResumeBuilder = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.Affinity_VR_Logo__1_;
            splitContainer1.Panel1.Controls.Add(btnNewsPictureButton);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnIllinoiis);
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            splitContainer1.Panel1.Controls.Add(cbChatCategory);
            splitContainer1.Panel1.Controls.Add(checkBox1);
            splitContainer1.Panel1.Controls.Add(dbAIInput1);
            splitContainer1.Panel1.Controls.Add(btnMich);
            splitContainer1.Panel1.Controls.Add(lblChatResponse);
            splitContainer1.Panel1.Controls.Add(btnKy);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Turquoise;
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(btnResumeBuilder);
            splitContainer1.Panel2.Controls.Add(cbIsBotMuted);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(tbChatOutput);
            splitContainer1.Panel2.Controls.Add(mainBannerPictureBox1);
            splitContainer1.Panel2.Controls.Add(btnTenn);
            splitContainer1.Panel2.Controls.Add(tbChatInput);
            splitContainer1.Panel2.Controls.Add(btnSubmitTextToBot);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(939, 622);
            splitContainer1.SplitterDistance = 319;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // btnNewsPictureButton
            // 
            btnNewsPictureButton.BackColor = Color.Transparent;
            btnNewsPictureButton.BackgroundImage = (Image)resources.GetObject("btnNewsPictureButton.BackgroundImage");
            btnNewsPictureButton.BackgroundImageLayout = ImageLayout.Stretch;
            btnNewsPictureButton.Location = new Point(8, 170);
            btnNewsPictureButton.Name = "btnNewsPictureButton";
            btnNewsPictureButton.Size = new Size(291, 251);
            btnNewsPictureButton.TabIndex = 12;
            btnNewsPictureButton.UseVisualStyleBackColor = false;
            btnNewsPictureButton.Click += btnNewsPictureButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(57, 442);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 7;
            label1.Text = "powered by:";
            // 
            // btnIllinoiis
            // 
            btnIllinoiis.BackColor = Color.Transparent;
            btnIllinoiis.BackgroundImage = (Image)resources.GetObject("btnIllinoiis.BackgroundImage");
            btnIllinoiis.BackgroundImageLayout = ImageLayout.Stretch;
            btnIllinoiis.Location = new Point(8, 527);
            btnIllinoiis.Name = "btnIllinoiis";
            btnIllinoiis.Size = new Size(90, 83);
            btnIllinoiis.TabIndex = 5;
            btnIllinoiis.UseVisualStyleBackColor = false;
            btnIllinoiis.Click += btnIllinoiis_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.chatgpt_logo_header_banner_345686558;
            pictureBox3.Location = new Point(154, 427);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // cbChatCategory
            // 
            cbChatCategory.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            cbChatCategory.FormattingEnabled = true;
            cbChatCategory.ImeMode = ImeMode.On;
            cbChatCategory.Items.AddRange(new object[] { "Educational", "Medical", "Entertainment", "Customer Service", "Create a 5 line Action Movie Script", "Create a short motivational rap song" });
            cbChatCategory.Location = new Point(12, 136);
            cbChatCategory.Name = "cbChatCategory";
            cbChatCategory.Size = new Size(287, 28);
            cbChatCategory.TabIndex = 11;
            cbChatCategory.Text = "Select Category";
            cbChatCategory.SelectedIndexChanged += HandleChatSelectionChange;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 106);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(220, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Create Database Connection";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // dbAIInput1
            // 
            dbAIInput1.AutoSize = true;
            dbAIInput1.Location = new Point(12, 76);
            dbAIInput1.Name = "dbAIInput1";
            dbAIInput1.Size = new Size(181, 24);
            dbAIInput1.TabIndex = 9;
            dbAIInput1.Text = "Create Simple Website";
            dbAIInput1.UseVisualStyleBackColor = true;
            dbAIInput1.Visible = false;
            // 
            // btnMich
            // 
            btnMich.BackColor = Color.Transparent;
            btnMich.BackgroundImage = (Image)resources.GetObject("btnMich.BackgroundImage");
            btnMich.BackgroundImageLayout = ImageLayout.Stretch;
            btnMich.Location = new Point(104, 527);
            btnMich.Name = "btnMich";
            btnMich.Size = new Size(90, 83);
            btnMich.TabIndex = 3;
            btnMich.UseVisualStyleBackColor = false;
            btnMich.Click += btnMich_Click;
            // 
            // lblChatResponse
            // 
            lblChatResponse.AutoSize = true;
            lblChatResponse.Location = new Point(2, 359);
            lblChatResponse.Name = "lblChatResponse";
            lblChatResponse.Size = new Size(0, 20);
            lblChatResponse.TabIndex = 4;
            // 
            // btnKy
            // 
            btnKy.BackColor = Color.Transparent;
            btnKy.BackgroundImage = Properties.Resources.kentucky_map_icon_414223723;
            btnKy.BackgroundImageLayout = ImageLayout.Stretch;
            btnKy.Location = new Point(200, 527);
            btnKy.Name = "btnKy";
            btnKy.Size = new Size(90, 83);
            btnKy.TabIndex = 2;
            btnKy.UseVisualStyleBackColor = false;
            btnKy.Click += btnKy_Click;
            // 
            // button3
            // 
            button3.Location = new Point(127, 22);
            button3.Name = "button3";
            button3.Size = new Size(109, 29);
            button3.TabIndex = 3;
            button3.Text = "Roblox";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
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
            // cbIsBotMuted
            // 
            cbIsBotMuted.AutoSize = true;
            cbIsBotMuted.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cbIsBotMuted.Location = new Point(522, 267);
            cbIsBotMuted.Name = "cbIsBotMuted";
            cbIsBotMuted.Size = new Size(64, 23);
            cbIsBotMuted.TabIndex = 7;
            cbIsBotMuted.Text = "Mute";
            cbIsBotMuted.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnGotoAdmin);
            panel1.Controls.Add(btnLockedTab);
            panel1.Controls.Add(tbApi);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(18, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 58);
            panel1.TabIndex = 6;
            // 
            // btnGotoAdmin
            // 
            btnGotoAdmin.BackColor = Color.Transparent;
            btnGotoAdmin.BackgroundImage = (Image)resources.GetObject("btnGotoAdmin.BackgroundImage");
            btnGotoAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnGotoAdmin.Location = new Point(60, 7);
            btnGotoAdmin.Name = "btnGotoAdmin";
            btnGotoAdmin.Size = new Size(42, 44);
            btnGotoAdmin.TabIndex = 8;
            btnGotoAdmin.UseVisualStyleBackColor = false;
            btnGotoAdmin.Click += btnGotoAdmin_Click;
            // 
            // btnLockedTab
            // 
            btnLockedTab.BackColor = Color.Transparent;
            btnLockedTab.BackgroundImage = (Image)resources.GetObject("btnLockedTab.BackgroundImage");
            btnLockedTab.BackgroundImageLayout = ImageLayout.Stretch;
            btnLockedTab.Location = new Point(12, 7);
            btnLockedTab.Name = "btnLockedTab";
            btnLockedTab.Size = new Size(42, 44);
            btnLockedTab.TabIndex = 7;
            btnLockedTab.UseVisualStyleBackColor = false;
            btnLockedTab.Click += btnLockedTab_Click;
            // 
            // tbApi
            // 
            tbApi.BackColor = SystemColors.InactiveCaption;
            tbApi.Location = new Point(206, 16);
            tbApi.Name = "tbApi";
            tbApi.PasswordChar = '*';
            tbApi.Size = new Size(231, 27);
            tbApi.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key_icon_png_20_2507228831;
            pictureBox2.Location = new Point(158, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.chatgpt_logo_header_banner_345686558;
            pictureBox1.Location = new Point(204, 577);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tbChatOutput
            // 
            tbChatOutput.BackColor = Color.PaleTurquoise;
            tbChatOutput.BorderStyle = BorderStyle.FixedSingle;
            tbChatOutput.Cursor = Cursors.PanNW;
            tbChatOutput.Enabled = false;
            tbChatOutput.Font = new Font("Snap ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbChatOutput.Location = new Point(3, 370);
            tbChatOutput.Multiline = true;
            tbChatOutput.Name = "tbChatOutput";
            tbChatOutput.Size = new Size(504, 201);
            tbChatOutput.TabIndex = 5;
            // 
            // mainBannerPictureBox1
            // 
            mainBannerPictureBox1.Image = Properties.Resources.Affinity_VR_Logo__1_1;
            mainBannerPictureBox1.ImageLocation = "";
            mainBannerPictureBox1.Location = new Point(3, 0);
            mainBannerPictureBox1.Name = "mainBannerPictureBox1";
            mainBannerPictureBox1.Size = new Size(504, 257);
            mainBannerPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            mainBannerPictureBox1.TabIndex = 1;
            mainBannerPictureBox1.TabStop = false;
            mainBannerPictureBox1.WaitOnLoad = true;
            // 
            // btnTenn
            // 
            btnTenn.BackColor = Color.Transparent;
            btnTenn.BackgroundImage = (Image)resources.GetObject("btnTenn.BackgroundImage");
            btnTenn.BackgroundImageLayout = ImageLayout.Stretch;
            btnTenn.Location = new Point(513, 488);
            btnTenn.Name = "btnTenn";
            btnTenn.Size = new Size(90, 83);
            btnTenn.TabIndex = 4;
            btnTenn.UseVisualStyleBackColor = false;
            btnTenn.Click += btnTenn_Click;
            // 
            // tbChatInput
            // 
            tbChatInput.Location = new Point(3, 281);
            tbChatInput.Multiline = true;
            tbChatInput.Name = "tbChatInput";
            tbChatInput.Size = new Size(504, 69);
            tbChatInput.TabIndex = 0;
            // 
            // btnSubmitTextToBot
            // 
            btnSubmitTextToBot.BackColor = SystemColors.ActiveCaption;
            btnSubmitTextToBot.BackgroundImageLayout = ImageLayout.Stretch;
            btnSubmitTextToBot.Location = new Point(513, 296);
            btnSubmitTextToBot.Name = "btnSubmitTextToBot";
            btnSubmitTextToBot.Size = new Size(99, 54);
            btnSubmitTextToBot.TabIndex = 2;
            btnSubmitTextToBot.Text = "Submit to ChatGPT";
            btnSubmitTextToBot.UseVisualStyleBackColor = false;
            btnSubmitTextToBot.Click += btnSubmitTextToBot_Click;
            // 
            // btnResumeBuilder
            // 
            btnResumeBuilder.BackgroundImage = Properties.Resources.resume_icon_png_1_2281174287;
            btnResumeBuilder.BackgroundImageLayout = ImageLayout.Stretch;
            btnResumeBuilder.ImageAlign = ContentAlignment.MiddleLeft;
            btnResumeBuilder.Location = new Point(513, 53);
            btnResumeBuilder.Name = "btnResumeBuilder";
            btnResumeBuilder.Size = new Size(94, 111);
            btnResumeBuilder.TabIndex = 8;
            btnResumeBuilder.TextAlign = ContentAlignment.BottomCenter;
            btnResumeBuilder.UseVisualStyleBackColor = true;
            btnResumeBuilder.Click += btnGotoResumeForm_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(513, 30);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 9;
            label2.Text = "Build a Resume";
            // 
            // AffinityMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            BackgroundImage = Properties.Resources.Affinity_VR_Logo__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(939, 622);
            Controls.Add(splitContainer1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AffinityMainForm";
            Text = "Welcome to Affinity! ";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainBannerPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private TextBox tbChatInput;
        private PictureBox mainBannerPictureBox1;
        private Button btnSubmitTextToBot;
        private Button button3;
        private Label lblChatResponse;
        private PictureBox pictureBox1;
        private TextBox tbChatOutput;
        private TextBox tbApi;
        private PictureBox pictureBox2;
        private Button btnMich;
        private Button btnKy;
        private Button btnIllinoiis;
        private Button btnTenn;
        private Panel panel1;
        private Button btnLockedTab;
        private Button btnGotoAdmin;
        private CheckBox checkBox1;
        private CheckBox dbAIInput1;
        private Label label1;
        private PictureBox pictureBox3;
        private ComboBox cbChatCategory;
        private CheckBox cbIsBotMuted;
        private Button btnNewsPictureButton;
        private Button btnResumeBuilder;
        private Label label2;
    }
}
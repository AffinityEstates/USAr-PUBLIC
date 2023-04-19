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
            pictureBox2 = new PictureBox();
            tbApi = new TextBox();
            pictureBox1 = new PictureBox();
            tbChatOutput = new TextBox();
            lblChatResponse = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tbChatInput = new TextBox();
            btnIllinoiis = new Button();
            btnTenn = new Button();
            btnMich = new Button();
            btnKy = new Button();
            mainBannerPictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLockedTab = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainBannerPictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(tbChatInput);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(btnIllinoiis);
            splitContainer1.Panel2.Controls.Add(btnTenn);
            splitContainer1.Panel2.Controls.Add(btnMich);
            splitContainer1.Panel2.Controls.Add(btnKy);
            splitContainer1.Panel2.Controls.Add(mainBannerPictureBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1221, 505);
            splitContainer1.SplitterDistance = 391;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
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
            // tbApi
            // 
            tbApi.BackColor = SystemColors.InactiveCaption;
            tbApi.Location = new Point(60, 92);
            tbApi.Name = "tbApi";
            tbApi.Size = new Size(231, 27);
            tbApi.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.chatgpt_logo_header_banner_345686558;
            pictureBox1.Location = new Point(145, 257);
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
            tbChatOutput.Font = new Font("Segoe UI Variable Text", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbChatOutput.Location = new Point(3, 295);
            tbChatOutput.Multiline = true;
            tbChatOutput.Name = "tbChatOutput";
            tbChatOutput.Size = new Size(385, 187);
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
            button3.Location = new Point(182, 22);
            button3.Name = "button3";
            button3.Size = new Size(109, 29);
            button3.TabIndex = 3;
            button3.Text = "Roblox";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.SUBMIT_BUTTON_4072490582;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(136, 158);
            button2.Name = "button2";
            button2.Size = new Size(118, 34);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // tbChatInput
            // 
            tbChatInput.Location = new Point(12, 146);
            tbChatInput.Multiline = true;
            tbChatInput.Name = "tbChatInput";
            tbChatInput.Size = new Size(118, 56);
            tbChatInput.TabIndex = 0;
            // 
            // btnIllinoiis
            // 
            btnIllinoiis.BackColor = Color.Transparent;
            btnIllinoiis.BackgroundImage = (Image)resources.GetObject("btnIllinoiis.BackgroundImage");
            btnIllinoiis.BackgroundImageLayout = ImageLayout.Stretch;
            btnIllinoiis.Location = new Point(712, 388);
            btnIllinoiis.Name = "btnIllinoiis";
            btnIllinoiis.Size = new Size(90, 83);
            btnIllinoiis.TabIndex = 5;
            btnIllinoiis.UseVisualStyleBackColor = false;
            btnIllinoiis.Click += btnIllinoiis_Click;
            // 
            // btnTenn
            // 
            btnTenn.BackColor = Color.Transparent;
            btnTenn.BackgroundImage = (Image)resources.GetObject("btnTenn.BackgroundImage");
            btnTenn.BackgroundImageLayout = ImageLayout.Stretch;
            btnTenn.Location = new Point(712, 246);
            btnTenn.Name = "btnTenn";
            btnTenn.Size = new Size(90, 83);
            btnTenn.TabIndex = 4;
            btnTenn.UseVisualStyleBackColor = false;
            btnTenn.Click += btnTenn_Click;
            // 
            // btnMich
            // 
            btnMich.BackColor = Color.Transparent;
            btnMich.BackgroundImage = (Image)resources.GetObject("btnMich.BackgroundImage");
            btnMich.BackgroundImageLayout = ImageLayout.Stretch;
            btnMich.Location = new Point(18, 246);
            btnMich.Name = "btnMich";
            btnMich.Size = new Size(90, 83);
            btnMich.TabIndex = 3;
            btnMich.UseVisualStyleBackColor = false;
            btnMich.Click += btnMich_Click;
            // 
            // btnKy
            // 
            btnKy.BackColor = Color.Transparent;
            btnKy.BackgroundImage = Properties.Resources.kentucky_map_icon_414223723;
            btnKy.BackgroundImageLayout = ImageLayout.Stretch;
            btnKy.Location = new Point(18, 388);
            btnKy.Name = "btnKy";
            btnKy.Size = new Size(90, 83);
            btnKy.TabIndex = 2;
            btnKy.UseVisualStyleBackColor = false;
            btnKy.Click += btnKy_Click;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnLockedTab);
            panel1.Location = new Point(18, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 58);
            panel1.TabIndex = 6;
            // 
            // btnLockedTab
            // 
            btnLockedTab.BackColor = Color.Transparent;
            btnLockedTab.BackgroundImage = (Image)resources.GetObject("btnLockedTab.BackgroundImage");
            btnLockedTab.BackgroundImageLayout = ImageLayout.Stretch;
            btnLockedTab.Location = new Point(48, 9);
            btnLockedTab.Name = "btnLockedTab";
            btnLockedTab.Size = new Size(42, 44);
            btnLockedTab.TabIndex = 7;
            btnLockedTab.UseVisualStyleBackColor = false;
            btnLockedTab.Click += btnLockedTab_Click;
            // 
            // AffinityMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            BackgroundImage = Properties.Resources.Affinity_VR_Logo__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1221, 505);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainBannerPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private TextBox tbChatInput;
        private PictureBox mainBannerPictureBox1;
        private Button button2;
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
    }
}
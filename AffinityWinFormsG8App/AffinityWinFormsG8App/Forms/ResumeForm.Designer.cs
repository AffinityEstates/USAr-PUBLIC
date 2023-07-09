namespace AffinityWinFormsG8App.Forms
{
    partial class ResumeForm
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
            btnSubmitToBot = new Button();
            lblLevel = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            btnSelectPDFType = new Button();
            tbChosenResumeFileType = new TextBox();
            btnSetResumeWord = new Button();
            SuspendLayout();
            // 
            // btnSubmitToBot
            // 
            btnSubmitToBot.Location = new Point(349, 381);
            btnSubmitToBot.Name = "btnSubmitToBot";
            btnSubmitToBot.Size = new Size(94, 57);
            btnSubmitToBot.TabIndex = 0;
            btnSubmitToBot.Text = "Create Resume";
            btnSubmitToBot.UseVisualStyleBackColor = true;
            btnSubmitToBot.Click += btnSubmitToBot_Click;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(12, 52);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(199, 20);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "How much work experience?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 52);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 2;
            label1.Text = "What's your most recent job or project?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 52);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter additional interests and keywords here:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Newly in the Workforce", "5 Years of Experience", "Seasoned", "Looking for Business Opportunities" });
            comboBox1.Location = new Point(12, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(493, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 27);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 7;
            label3.Text = "Resume File Type";
            // 
            // btnSelectPDFType
            // 
            btnSelectPDFType.BackgroundImage = Properties.Resources.PDF_icon_1_2186195913;
            btnSelectPDFType.BackgroundImageLayout = ImageLayout.Stretch;
            btnSelectPDFType.Location = new Point(26, 251);
            btnSelectPDFType.Name = "btnSelectPDFType";
            btnSelectPDFType.Size = new Size(109, 117);
            btnSelectPDFType.TabIndex = 8;
            btnSelectPDFType.UseVisualStyleBackColor = true;
            btnSelectPDFType.Click += btnSelectPDFType_Click;
            // 
            // tbChosenResumeFileType
            // 
            tbChosenResumeFileType.BackColor = SystemColors.InactiveCaption;
            tbChosenResumeFileType.Enabled = false;
            tbChosenResumeFileType.Location = new Point(141, 200);
            tbChosenResumeFileType.Name = "tbChosenResumeFileType";
            tbChosenResumeFileType.Size = new Size(70, 27);
            tbChosenResumeFileType.TabIndex = 9;
            tbChosenResumeFileType.Text = "PDF";
            // 
            // btnSetResumeWord
            // 
            btnSetResumeWord.BackgroundImage = Properties.Resources.word_icon;
            btnSetResumeWord.BackgroundImageLayout = ImageLayout.Stretch;
            btnSetResumeWord.Location = new Point(159, 251);
            btnSetResumeWord.Name = "btnSetResumeWord";
            btnSetResumeWord.Size = new Size(107, 117);
            btnSetResumeWord.TabIndex = 10;
            btnSetResumeWord.UseVisualStyleBackColor = true;
            btnSetResumeWord.Click += btnSetResumeWord_Click;
            // 
            // ResumeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetResumeWord);
            Controls.Add(tbChosenResumeFileType);
            Controls.Add(btnSelectPDFType);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLevel);
            Controls.Add(btnSubmitToBot);
            Name = "ResumeForm";
            Text = "ResumeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmitToBot;
        private Label lblLevel;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button btnSelectPDFType;
        private TextBox tbChosenResumeFileType;
        private Button btnSetResumeWord;
    }
}
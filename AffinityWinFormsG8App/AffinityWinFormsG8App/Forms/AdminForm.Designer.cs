namespace AffinityWinFormsG8App.Forms
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            gvAffinityUsers = new DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            affinityUserBindingSource = new BindingSource(components);
            gvCategories = new DataGridView();
            categoryIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            btnSaveAdmin = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)gvAffinityUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)affinityUserBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gvAffinityUsers
            // 
            gvAffinityUsers.AutoGenerateColumns = false;
            gvAffinityUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvAffinityUsers.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            gvAffinityUsers.DataSource = affinityUserBindingSource;
            gvAffinityUsers.Location = new Point(12, 64);
            gvAffinityUsers.Name = "gvAffinityUsers";
            gvAffinityUsers.RowHeadersWidth = 51;
            gvAffinityUsers.RowTemplate.Height = 29;
            gvAffinityUsers.Size = new Size(553, 170);
            gvAffinityUsers.TabIndex = 0;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // affinityUserBindingSource
            // 
            affinityUserBindingSource.DataSource = typeof(Models.AffinityUser);
            // 
            // gvCategories
            // 
            gvCategories.AutoGenerateColumns = false;
            gvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCategories.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn });
            gvCategories.DataSource = categoryBindingSource;
            gvCategories.Location = new Point(12, 240);
            gvCategories.Name = "gvCategories";
            gvCategories.RowHeadersWidth = 51;
            gvCategories.RowTemplate.Height = 29;
            gvCategories.Size = new Size(305, 170);
            gvCategories.TabIndex = 1;
            // 
            // categoryIdDataGridViewTextBoxColumn1
            // 
            categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
            categoryIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // btnSaveAdmin
            // 
            btnSaveAdmin.BackColor = Color.FloralWhite;
            btnSaveAdmin.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveAdmin.Location = new Point(747, 377);
            btnSaveAdmin.Name = "btnSaveAdmin";
            btnSaveAdmin.Size = new Size(126, 33);
            btnSaveAdmin.TabIndex = 2;
            btnSaveAdmin.Text = "Save Changes";
            btnSaveAdmin.UseVisualStyleBackColor = false;
            btnSaveAdmin.Click += btnSaveAdmin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FloralWhite;
            btnCancel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(615, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 33);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(900, 427);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveAdmin);
            Controls.Add(gvCategories);
            Controls.Add(gvAffinityUsers);
            Cursor = Cursors.Cross;
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)gvAffinityUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)affinityUserBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvAffinityUsers;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource affinityUserBindingSource;
        private DataGridView gvCategories;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private Button btnSaveAdmin;
        private Button btnCancel;
    }
}
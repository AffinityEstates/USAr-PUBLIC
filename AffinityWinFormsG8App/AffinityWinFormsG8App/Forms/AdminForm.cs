using AffinityWinFormsG8App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffinityWinFormsG8App.Forms
{
    public partial class AdminForm : Form
    {
        private AffinityUserContext? dbContext;

        public AdminForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new AffinityUserContext();

            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();

            // TODO: fix
            //this.categoryBindingSource = dbContext.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext=null;
        }

        private void btnSaveAdmin_Click(object sender, EventArgs e)
        {
            // Save data
        }
    }
}

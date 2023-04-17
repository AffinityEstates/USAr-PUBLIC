using System.Configuration;

namespace AffinityWinFormsG8App
{
    public partial class AffinityMainForm : Form
    {
        public AffinityMainForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open Oculus app locally if exists, download link if not exists

            System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["mainAffinityURL"]);
        }
    }
}
/*
    Effective Date: January 1, 2023.

    Affinity and its subsidiaries and affiliates (collectively, “Affinity”, “us” or “we”) understand that your privacy is important to you. We are committed to respecting your privacy and protecting your personal data, which is any information that is capable of identifying you as an individual person. 
    This Privacy Policy describes how we handle and protect your personal data in connection with Affinity's business activities, like conferences and events, and client services, and on websites, applications, and communications that post a link 
    to this Privacy Policy (collectively, “the Sites”), in our capacity as data controllers.
 * */

using System.Configuration;
using System.Diagnostics;
using AffinityWinFormsG8App.Models;

namespace AffinityWinFormsG8App
{
    public partial class AffinityMainForm : Form
    {
        public AffinityMainForm()
        {
            InitializeComponent();

            setupBannerImage();
        }

        private void setupBannerImage()
        {
            return;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open Oculus app locally if exists, download link if not exists

            // TODO: Fix accessing config file!
            // System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["mainAffinityURL"]);
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.affinityestates.us",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // handle chat bot here!
            ChatBot.setChatBotResponse();
            lblChatResponse.Text = ChatBot.ChatBotResponse;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: Fix accessing config file!
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.roblox.com/games/10383092478/Willow-Wonderland-Super-Obby-and-Racetrack",
                UseShellExecute = true
            });
        }
    }
}
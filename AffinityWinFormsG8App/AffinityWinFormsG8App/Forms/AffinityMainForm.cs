/*
    Effective Date: January 1, 2023.

    Affinity and its subsidiaries and affiliates (collectively, “Affinity”, “us” or “we”) understand that your privacy is important to you. We are committed to respecting your privacy and protecting your personal data, which is any information that is capable of identifying you as an individual person. 
    This Privacy Policy describes how we handle and protect your personal data in connection with Affinity's business activities, like conferences and events, and client services, and on websites, applications, and communications that post a link 
    to this Privacy Policy (collectively, “the Sites”), in our capacity as data controllers.
 * */

using System.Diagnostics;
using AffinityWinFormsG8App.Forms;
using AffinityWinFormsG8App.Models;
using Microsoft.Win32;
using System.Speech.Synthesis;
using System.Globalization;

namespace AffinityWinFormsG8App
{
    public partial class AffinityMainForm : Form
    {
        public AffinityMainForm()
        {
            InitializeComponent();

            ConfigureWindowsRegistry();

            setupBannerImage();
        }

        private void setupBannerImage()
        {
            this.tbChatInput.Focus();
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

        private async void button2_Click(object sender, EventArgs e)
        {
            
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form apiForm = new ConfigAPIKeyModalForm();
            apiForm.Show();
        }

        private void btnKy_Click(object sender, EventArgs e)
        {
            // TODO: Fix accessing config file!
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://oculus.com/vr/5565755033439642/",
                UseShellExecute = true
            });
        }

        private void btnMich_Click(object sender, EventArgs e)
        {
            // TODO: Fix accessing config file!
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://oculus.com/vr/4369207463185527/",
                UseShellExecute = true
            });
        }

        private void btnTenn_Click(object sender, EventArgs e)
        {
            // TODO: Fix accessing config file!
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://oculus.com/vr/8081789058501624/",
                UseShellExecute = true
            });
        }

        private void btnIllinoiis_Click(object sender, EventArgs e)
        {
            // TODO: Fix accessing config file!
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://oculus.com/vr/5832979190063128/",
                UseShellExecute = true
            });
        }

        private void btnLockedTab_Click(object sender, EventArgs e)
        {
            // TODO: Handle locked feature logic here
        }

        private void btnGotoAdmin_Click(object sender, EventArgs e)
        {
            // Goto Admin screen            
            AdminForm admin = new AdminForm();
            admin.ShowDialog(this);
        }

        private void ConfigureWindowsRegistry()
        {
            RegistryKey localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);

            var reg = localMachine.OpenSubKey("Software\\Affinity", true);
            if (reg == null)
            {
                reg = localMachine.CreateSubKey("Software\\Affinity");
            }

            if (reg.GetValue("DefaultChatKey") == null)
            {
                reg.SetValue("DefaultChatKey", "UpdateThisKey");
            }
            else
            {
                this.tbApi.Text = reg.GetValue("DefaultChatKey").ToString();

                // TODO: Enable the copy/paste function as a key feature
                this.tbChatOutput.Enabled = true;
            }
        }

        private void HandleChatSelectionChange(object sender, EventArgs e)
        {
            tbChatInput.Text = $"Can you provide a sample script for this category: {cbChatCategory.Text}";
        }

        private void btnNewsPictureButton_Click(object sender, EventArgs e)
        {
            // TODO: Fix accessing config file!
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.affinityestates.us",
                UseShellExecute = true
            });
        }

        private bool isValidKey(String key)
        {
            var isValid = true;

            if (String.IsNullOrEmpty(key))
            {
                isValid = false;
            }

            return isValid;
        }

        private async void btnSubmitTextToBot_Click(object sender, EventArgs e)
        {
            // if no key, return
            if (!isValidKey(tbApi.Text))
            {
                MessageBox.Show("Please enter a valid product key.");
                return;
            }

            // handle chat bot async call here!
            await ChatBot.setChatBotResponseAsync(tbChatInput.Text, tbApi.Text);

            tbChatOutput.Text = $"ChatGPT Response: {ChatBot.ChatBotResponse}";
            Refresh();
            
            if (!cbIsBotMuted.Checked) // speak! if not muted
            {
                SpeechSynthesizer syn = new SpeechSynthesizer();
                syn.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo("pt-BR"));
                syn.Volume = 100;  // (0 - 100)
                syn.Rate = 0;     // (-10 - 10)
                syn.SetOutputToDefaultAudioDevice();
                syn.SpeakAsync(ChatBot.ChatBotResponse);
            }

            tbChatInput.Focus();
        }
    }
}
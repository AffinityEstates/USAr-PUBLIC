using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinityWinFormsG8App.Models
{
    public static class ChatBot
    {
        public static String? ChatBotResponse { get; set; }

        public static void setChatBotResponse()
        {
            ChatBot.ChatBotResponse = "This is all I can say for now";

            // TODO: Implement chatbot

            return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatGPT.Net;

namespace AffinityWinFormsG8App.Models
{
    public static class ChatBot
    {
        public static String? ChatBotResponse { get; set; }

        public static async Task setChatBotResponseAsync(String input)
        {

            // ChatGPT Official API
            // TODO: Move to config
            var bot = new ChatGpt("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");

            var response = await bot.Ask(input);
            Console.WriteLine(response);

            ChatBot.ChatBotResponse = response;

            // TODO: Implement chatbot

            return;
        }
    }
}

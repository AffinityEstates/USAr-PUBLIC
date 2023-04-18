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

        public static async Task setChatBotResponseAsync(String input, String key)
        {

            // ChatGPT Official API
            // TODO: Move to config
            var bot = new ChatGpt(key);
            ChatBotResponse = String.Empty;

            var response = await bot.Ask(input);
            Console.WriteLine(response);

            ChatBot.ChatBotResponse = response;

            // TODO: Implement chatbot

            return;
        }
    }
}

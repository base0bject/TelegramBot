using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "Привет";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatID = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: логика бота


            await client.SendTextMessageAsync(chatID, "Привет!", replyToMessageId: messageId);
        }
    }
}
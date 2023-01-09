using System.Net.WebSockets;
using Telegram.Bot;
using Telegram.Bot.Types;

var client = new TelegramBotClient("");
client.StartReceiving(Update, Error);

async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token) 
{
    var message = update.Message;
    if (message.Text.ToLower().Contains("зефир"))
    {
        await botClient.SendTextMessageAsync(message.Chat.Id, "зефир любят еноты");
        
    }    
    else if (message.Text != null)
    {
        Console.WriteLine($" {message.Chat.Id}  {message.Chat.FirstName}  {message.Text}  {message.Chat.Location}");
        await botClient.SendTextMessageAsync(message.Chat.Id, $"{message.Text}");
    }
    
}
static Task Error(ITelegramBotClient botClient, Exception exception, CancellationToken token) 
{
    throw new NotImplementedException();
}
Console.ReadLine();
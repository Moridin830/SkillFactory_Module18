
namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите URL:");
            string URL = Console.ReadLine() ?? "";

            if (URL == "")
            {
                Console.WriteLine("Некорректный URL.");
                return;
            }

            // создадим отправителя
            var user = new YoutubeUser();

            // создадим получателя
            var worker = new YoutubeWorker();

            // создадим команду для получения данных о видео
            var commandGetInfo = new CommandGetInfo(worker);

            // создадим команду для загрузки видео
            var commandDownloadInfo = new CommandDownloadVideo(worker);

            // инициализация команды получения информации
            user.SetCommandGetInfo(commandGetInfo);

            // инициализация команды получения информации
            user.SetCommandDownloadVideo(commandDownloadInfo);

            //  выполнение
            user.Run(URL);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
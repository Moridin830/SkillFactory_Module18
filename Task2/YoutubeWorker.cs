using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task2
{
    public class YoutubeWorker
    {
        public async void OperationGetInfo(string URL)
        {
            StringOperations.WriteDelimiter();
            Console.WriteLine("Запрашиваем данные...");
            StringOperations.WriteDelimiter();

            var YoutubeClient = new YoutubeClient();

            var video = await YoutubeClient.Videos.GetAsync(URL);
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");

            
        }

        public async void OperationDownloadVideo(string URL)
        {
            StringOperations.WriteDelimiter();
            Console.WriteLine("Начинаем загрузку видео...");
            StringOperations.WriteDelimiter();

            var YoutubeClient = new YoutubeClient();

            // Получаем адрес каталога рабочего стола текущей системы
            string DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            // Формируем адрес каталога для сохранения файла
            string DirectoryURL = DesktopDirectory + "/" + "video.mp4";
            await YoutubeClient.Videos.DownloadAsync(URL, DirectoryURL, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine($"Загрузка видео завершена");
        }
    }
}
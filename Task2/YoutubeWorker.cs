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
            var YoutubeClient = new YoutubeClient();

            var video = await YoutubeClient.Videos.GetAsync(URL);
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");

            
        }

        public async void OperationDownloadVideo(string URL)
        {
            var YoutubeClient = new YoutubeClient();

            await YoutubeClient.Videos.DownloadAsync(URL, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine($"Загрузка видео завершена");
        }
    }
}
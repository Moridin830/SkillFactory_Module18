using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class YoutubeUser
    {
        Command _commandGetInfo;

        Command _commandDownloadVideo;

        public void SetCommandGetInfo(Command command)
        {
            _commandGetInfo = command;
        }

        public void SetCommandDownloadVideo(Command command)
        {
            _commandDownloadVideo = command;
        }

        // Выполнить
        public void Run(string URL)
        {
            _commandGetInfo.Run(URL);
            _commandDownloadVideo.Run(URL);
        }
    }
}

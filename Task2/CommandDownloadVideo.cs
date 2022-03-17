using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task2
{
    public class CommandDownloadVideo:Command
    {
        YoutubeWorker worker;

        public CommandDownloadVideo(YoutubeWorker worker)
        {
            this.worker = worker;
        }

        public override void Run(string URL)
        {
            worker.OperationDownloadVideo(URL);
        }
    }
}

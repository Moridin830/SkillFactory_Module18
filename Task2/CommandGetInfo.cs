using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Task2
{
    public class CommandGetInfo:Command
    {
        YoutubeWorker worker;

        public CommandGetInfo(YoutubeWorker worker)
        {
            this.worker = worker;
        }
        
        public override void Run(string URL)
        {
            worker.OperationGetInfo(URL);
        }
    }
}

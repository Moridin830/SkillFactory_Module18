using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Task2
{
    public abstract class Command
    {
        public abstract void Run(string URL);
    }
}

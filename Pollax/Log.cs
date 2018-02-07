using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollax
{
    public class Log
    {
        public static void log(string text)
        {
            if (!Directory.Exists("server")) Directory.CreateDirectory("server");
            string path = Properties.Settings.Default.log_path;
            StreamWriter sw = new StreamWriter(path + System.DateTime.Today + ".log");
            sw.Write(text);
        }
    }
}
 
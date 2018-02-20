using System;
using System.IO;

namespace Pollax
{
    internal class GetSettings
    {
        static Int32 GetPortNumber()
        {
            return (Int32) int.Parse(File.ReadAllText(@"C:\pollaxdata\server\pref\port.dat"));
        }

        static Boolean ReportErrorBool()
        {
            return bool.Parse(File.ReadAllText(@"C:\pollaxdata\server\pref\report_error.dat"));
        }

        static String GetWebserverDirectory()
        {
            return (String)File.ReadAllText(@"C:\pollaxdata\server\pref\webserver_dir.dat");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sempt3x_Port_Scanner
{
    static class SaveHandler
    {
        public static Int32 Second = DateTime.Now.Second;
        public static Int32 Minute = DateTime.Now.Minute;
        public static Int32 Hour = DateTime.Now.Hour;
        public static Int32 Day = DateTime.Now.Day;
        public static Int32 Month = DateTime.Now.Month;
        public static Int32 Year = DateTime.Now.Year;

        public static List<string> Logs = new List<string>();

        static public void AddLogs(string Value)
        {
            try
            {
                Logs.Add(Value);
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void SaveLogsAsFile()
        {
            try
            {
                System.IO.File.WriteAllLines("SCAN_" + Year + "_" + Month + "_" + Day + "_" + Hour + "_" + Minute + "_" + Second + ".txt", Logs);
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

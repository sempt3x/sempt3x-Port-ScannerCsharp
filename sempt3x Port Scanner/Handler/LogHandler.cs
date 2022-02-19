using System;

namespace sempt3x_Port_Scanner
{
    public class LogHandler
    {
        
    }

    public static class Log
    {
        public static void Err(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }

        public static void Rdy(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }

        public static void Msg(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
        }
    }
}
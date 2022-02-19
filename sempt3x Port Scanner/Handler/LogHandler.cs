using System;

namespace sempt3x_Port_Scanner
{
    public class LogHandler
    {
        
    }

    public static class Log
    {
        public static void Error(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }

        public static void Correct(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }

        public static void msg(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
        }
    }
}
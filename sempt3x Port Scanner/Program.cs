// Author: sempt3x
// Copyright 2021

using System;

namespace sempt3x_Port_Scanner
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; // Set Start Color to White

            //* Application Information *//

            Console.WriteLine(" SEMPT3X Port Scanner v3.0.0 \n"); // Program Console Beginning Text
            Console.Title = "SEMPT3X Port Scanner v3.0.0"; // Program Title Text

            do
            {
                StatusHandler.IpInput();

                StatusHandler.Port1Input();
                StatusHandler.Port2Input();

                Console.WriteLine("\n");

                StatusHandler.CheckStatus();

                Console.ForegroundColor = ConsoleColor.White; // Change Console Font Color to White

                //** Set all Values of Variables to Default **//

                StatusHandler.ResetValues();

            } while (true);
        }
    }
}
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

            Console.WriteLine(" SEMPT3X Port Scanner v3.5.0 \n"); // Program Console Beginning Text
            Console.Title = "SEMPT3X Port Scanner v3.5.0"; // Program Title Text

            do
            {
                // IP Eingabe

                StatusHandler.IpInput();

                // Port 1 eingabe

                StatusHandler.Port1Input();

                // Port 2 eingabe

                StatusHandler.Port2Input();

                Console.WriteLine("\n");

                // Prüfung der Eingabe

                StatusHandler.CheckStatus();

                Console.ForegroundColor = ConsoleColor.White; // Change Console Font Color to White

                //** Set all Values of Variables to Default **//

                StatusHandler.ResetValues();

            } while (true);
        }
    }
}
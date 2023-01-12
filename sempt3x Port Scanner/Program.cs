// Author: sempt3x
// Copyright 2021

using System;

namespace sempt3x_Port_Scanner
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "TCP Port Scanner made by sempt3x";
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

            StatusHandler.EndOfProgram();
        }
        
    }
}
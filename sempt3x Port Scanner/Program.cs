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

            Console.WriteLine(" SEMPT3X Port Scanner v2.1.0 \n"); // Program Console Beginning Text
            Console.Title = "SEMPT3X Port Scanner v2.1.0"; // Program Title Text

            //* Begin Frist Loop **//

            do
            {
                Console.Write("\n Enter the IP address: "); // IP Adress Input

                //** Begin Second Loop **/

                do {
                    if (!string.IsNullOrEmpty(StatusHandler.Ipeingabe))
                    {
                        StatusHandler.Checkinput1 = false;
                    }
                    else
                    {
                        StatusHandler.Checkinput1 = true;
                        StatusHandler.Ipeingabe = Convert.ToString(Console.ReadLine());
                    }
                } while (StatusHandler.Checkinput1);

                //** End Second Loop **//

                //** Begin Third Loop **//

                do {
                    StatusHandler.Port1_input();
                    StatusHandler.Port2_input();
                } while (StatusHandler.Checkinput2 || StatusHandler.Checkinput3);

                //** End Third Loop **//

                Console.WriteLine("\n");

                //** Begin Fourth Loop **//

                do
                {
                    StatusHandler.CheckStatus();
                } while (StatusHandler.Port1
                < StatusHandler.Port2);

                //** End Fourth Loop **//

                Console.ForegroundColor = ConsoleColor.White; // Change Console Font Color to White

                //** Set all Values of Variables to Default **//

                StatusHandler.ResetValues();
            } while (true);
            //** End First Loop **//
        }
    }
}
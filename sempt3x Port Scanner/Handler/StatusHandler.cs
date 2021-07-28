﻿using Newtonsoft.Json;
using System;
using System.Net.Sockets;

namespace sempt3x_Port_Scanner
{
  public static class StatusHandler
    {
        // Variablen

        public static string Ipeingabe { get; set; } = "";

        public static int Port1 { get; set; } = 0;

        public static int Port2 { get; set; } = 2;

        public static bool Checkinput1 { get; set; } = true;

        public static bool Checkinput2 { get; set; } = true;

        public static bool Checkinput3 { get; set; } = true;


        // IP Eingabge und Prüfung

        public static void IpInput()
        {
            Console.Write("\n Enter the IP address: "); // IP Adress Input
            do
            {
                if (!string.IsNullOrEmpty(Ipeingabe))
                {
                    Checkinput1 = false;
                }
                else
                {
                    Checkinput1 = true;
                    Ipeingabe = Convert.ToString(Console.ReadLine());
                }
            } while (Checkinput1);
        }

        // Port1 Eingabe und Prüfung

        public static void Port1Input()
        {
            Console.Write(" Enter the first port: "); // Port 1 Input
            try
            {
                Port1 = Convert.ToInt32(Console.ReadLine());
                Checkinput2 = string.IsNullOrEmpty(Port1.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine(" Failed!");
            }
        }

        // Port2 Eingabe und Prüfung

        public static void Port2Input()
        {
            Console.Write(" Enter the second port: "); // Port 2 Input
            try
            {
                Port2 = Convert.ToInt32(Console.ReadLine());
                Checkinput3 = string.IsNullOrEmpty(Port2.ToString());
            }
            catch
            {
                Console.WriteLine(" Failed!");
            }
        }

        // Funktion zum Prüfen des Status

        public static void CheckStatus()
        {
            do
            {
                TcpClient client = new TcpClient();
                Port1++;

                IAsyncResult result = client.BeginConnect(Ipeingabe, Port1, null, null);
                bool sucess = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                if (!sucess)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // If Port closed -> Red
                    string Finish = " [TCP-Port: " + Port1 + " ] Port is not open!";
                    Console.WriteLine(Finish);
                    SaveHandler.AddLogs(Finish);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; // If Port open -> Green
                    string Finish = " [TCP-Port: " + Port1 + " ] Port is open!";
                    Console.WriteLine(Finish);
                    SaveHandler.AddLogs(Finish);
                }
            } while (Port1< Port2);
            SaveHandler.SaveLogsAsFile();
        }

        // Funktion zum resetten den Werte

        public static void ResetValues()
        {
            Checkinput1 = true;
            Checkinput2 = true;
            Checkinput3 = true;
            Ipeingabe = "";
            Port1 = 0;
            Port2 = 0;
        }
    }
}
// Author: sempt3x
// Copyright 2021

using System;
using System.Net.Sockets;

namespace sempt3x_Port_Scanner
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; // Set Start Color to White
            //* Create Object *//
            var chs = new CheckStatus();

            //* Application Information *//
            Console.WriteLine(" SEMPT3X Port Scanner v1.2.0 \n"); // Program Console Beginning Text
            Console.Title = "SEMPT3X Port Scanner v1.2.0"; // Program Title Text

            //* Begin Frist Loop **//
            do
            {
                Console.Write("\n Enter the IP address: "); // IP Adress Input
                //** Begin Second Loop **/
                do {
                    if(string.IsNullOrEmpty(chs.Ipeingabe)) {
                        chs.Checkinput1 = true;
                        chs.Ipeingabe = Convert.ToString(Console.ReadLine());
                    } else {
                        chs.Checkinput1 = false;
                    }
                }while(chs.Checkinput1 == true);
                //** End Second Loop **//
                //** Begin Third Loop **//
                do {
                    Console.Write(" Enter the first port: "); // Port 1 Input
                    try
                    {
                        chs.Port1 = Convert.ToInt32(Console.ReadLine());
                        chs.Checkinput2 = string.IsNullOrEmpty(chs.Port1.ToString());
                    }
                    catch(FormatException) {
                        Console.WriteLine(" Failed!");
                    }
                    Console.Write(" Enter the second port: "); // Port 2 Input
                    try
                    {
                        chs.Port2 = Convert.ToInt32(Console.ReadLine());
                        chs.Checkinput3 = string.IsNullOrEmpty(chs.Port2.ToString());
                    } catch {
                        Console.WriteLine(" Failed!");
                    }
                }while(chs.Checkinput2|| chs.Checkinput3);
                //** End Third Loop **//
                Console.WriteLine("\n");
                //** Begin Fourth Loop **//
                do
                {
                    var client = new TcpClient();
                    chs.Port1++;
                    
                        var result = client.BeginConnect(chs.Ipeingabe, chs.Port1, null, null);
                        var sucess = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                        if (!sucess)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // If Port closed -> Red
                            Console.WriteLine(" [TCP-Port: " + chs.Port1 + " ] Port is not open!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // If Port open -> Green
                            Console.WriteLine(" [TCP-Port: " + chs.Port1 + " ] Port is open!");
                        }
                } while (chs.Port1 < chs.Port2);
                //** End Fourth Loop **//
                Console.ForegroundColor = ConsoleColor.White; // Change Console Font Color to White
                //** Set all Values of Variables to Default **//
                chs.Checkinput1 = true;
                chs.Checkinput2 = true;
                chs.Checkinput3 = true;
                chs.Ipeingabe = "";
                chs.Port1 = 0;
                chs.Port2 = 0;
            } while (true);
            //** End First Loop **//
        }
    }
}
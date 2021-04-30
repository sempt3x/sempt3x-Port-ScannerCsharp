// Author: sempt3x
// Copyright 2021


using System;
using System.Net.Sockets;

namespace sempt3x_Port_Scanner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SEMPT3X Port Scanner v1.0.2 \n\n"); // Programm Console Beginning Text
            Console.Title = "SEMPT3X Port Scanner v1.0.2";
            do
            {
                //* Define Variables *//
                string ipeingabe = "";
                int port_1 = 0, port_2 = 0;

                Console.Write("Enter the IP address: "); // IP Adress Input
                ipeingabe = Convert.ToString(Console.ReadLine());

                Console.Write("Enter the first port: "); // Port1 Input
                port_1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second port: "); // Port2 Input
                port_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                do // Begin Do While Loop
                {
                    TcpClient client = new TcpClient();
                    port_1++;
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        client.Connect(ipeingabe, port_1);
                        client.SendTimeout = 1;
                        Console.WriteLine("[TCP-Port: " + port_1 + " ] Port is open!");
                    }
                    catch (SocketException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[TCP-Port: " + port_1 + " ] Port is not open!");
                        client.SendTimeout = 1;
                    }
                } while (port_1 < port_2); // End Do While Loop

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n");
            } while (true);

            // Program Ending
        }
    }
}
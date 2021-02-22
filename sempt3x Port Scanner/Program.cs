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
            //* Define Variables *//
            string ipeingabe = "";
            int port1 = 0, port2 = 0;

            Console.WriteLine("SEMPT3X Port Scanner v1.0.1 \n\n"); // Programm Console Beginning Text
            Console.Title = "SEMPT3X Port Scanner v1.0.1";

            Console.Write("Enter the IP address: "); // IP Adress Input
            ipeingabe = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the first port: "); // Port1 Input
            port1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second port: "); // Port2 Input
            port2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            do // Begin Do While Loop
            {
                TcpClient client = new TcpClient();
                port1++;
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    client.Connect(ipeingabe,port1);
                    client.SendTimeout = 1;
                    Console.WriteLine("[TCP-Port: " + port1 + " ] Port is open!");
                }
                catch (SocketException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[TCP-Port: " + port1 + " ] Port is not open!");
                    client.SendTimeout = 1;
                } 
            } while (port1 < port2); // End Do While Loop

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n");
            Console.WriteLine("Please Press Button");
            Console.ReadKey();
            // Program Ending
        }
    }
}
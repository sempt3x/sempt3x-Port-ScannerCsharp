// Author: sempt3x
// Copyright 2021


using System;
using System.Net.Sockets;

namespace sempt3x_Port_Scanner
{
    class CheckStatus {
        //* Define Variables *//
        public string ipeingabe = "";
        public int port_1 = 0, port_2 = 0;
        public bool checkinput1 = true, checkinput2 = true, checkipinput = true;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            //* Create Object *//
            CheckStatus chs = new CheckStatus();

            //* Application Information *//
            Console.WriteLine("SEMPT3X Port Scanner v1.1.1 \n\n"); // Program Console Beginning Text
            Console.Title = "SEMPT3X Port Scanner v1.1.1"; // Program Title Text

            //* Begin Frist Loop **//
            do
            {
                Console.Write("Enter the IP address: "); // IP Adress Input

                //** Begin Second Loop **/
                do {
                    chs.ipeingabe = Convert.ToString(Console.ReadLine());
                    if(String.IsNullOrEmpty(chs.ipeingabe)) {
                        chs.checkipinput = true;
                    } else {
                        chs.checkipinput = false;
                            }
                }while(chs.checkipinput == true);
                //** End Second Loop **//
                //** Begin Third Loop **//
                do {
                Console.Write("Enter the first port: "); // Port 1 Input
                try {
                    chs.port_1 = Convert.ToInt32(Console.ReadLine());
                        if(String.IsNullOrEmpty(chs.port_1.ToString())) {
                            chs.checkinput1 = true;
                        } else {
                            chs.checkinput1 = false;
                        }
                }
                catch(System.FormatException) {
                    Console.WriteLine("Failed!");
                }
                Console.Write("Enter the second port: "); // Port 2 Input
                try {
                    chs.port_2 = Convert.ToInt32(Console.ReadLine());
                        if(String.IsNullOrEmpty(chs.port_2.ToString())) {
                            chs.checkinput2 = true;
                        } else {
                            chs.checkinput2 = false;
                        }
                } catch {
                    Console.WriteLine("Failed!");
                }
                }while(chs.checkinput1 == true || chs.checkinput2 == true);
                //** End Third Loop **//
                Console.WriteLine("\n");
                //** Begin Fourth Loop **//
                do
                {
                    TcpClient client = new TcpClient();
                    chs.port_1++;
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        client.Connect(chs.ipeingabe, chs.port_1);
                        client.SendTimeout = 1;
                        Console.WriteLine("[TCP-Port: " + chs.port_1 + " ] Port is open!");
                    }
                    catch (SocketException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[TCP-Port: " + chs.port_1 + " ] Port is not open!");
                        client.SendTimeout = 1;
                    }
                } while (chs.port_1 < chs.port_2);
                //** End Fourth Loop **//
            } while (true);
            //** End First Loop **//


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n");

            // Program Ending
        }
    }
}
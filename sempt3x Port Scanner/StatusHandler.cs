using System;
using System.Net.Sockets;

namespace sempt3x_Port_Scanner
{
  static class StatusHandler
    {
        public static string Ipeingabe { get; set; } = "";

        public static int Port1 { get; set; }

        public static int Port2 { get; set; }

        public static bool Checkinput1 { get; set; } = true;

        public static bool Checkinput2 { get; set; } = true;

        public static bool Checkinput3 { get; set; } = true;

        public static void InputValues()
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

        public static void CheckStatus()
        {
            var client = new TcpClient();
            Port1++;

            var result = client.BeginConnect(Ipeingabe, Port1, null, null);
            var sucess = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
            if (!sucess)
            {
                Console.ForegroundColor = ConsoleColor.Red; // If Port closed -> Red
                Console.WriteLine(" [TCP-Port: " + Port1 + " ] Port is not open!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green; // If Port open -> Green
                Console.WriteLine(" [TCP-Port: " + Port1 + " ] Port is open!");
            }
        }

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

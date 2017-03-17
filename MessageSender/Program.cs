using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace MessageSender
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                string message = "";


                if (args.Length == 0)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("Leave a new Message");
                    Console.WriteLine("");
                    message = Console.ReadLine();
                    Console.WriteLine("");
                    string messageNumber = "Message" + String.Format("{0:000}", i);
                    File.WriteAllLines(messageNumber + ".txt", new string[] { message });
                    i++;
                    Console.WriteLine("The Message has been sent!");
                    Console.WriteLine("");
                }
                else
                {
                    message = String.Concat(args);
                }



                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape) break;
                Thread.Sleep(1000);
            }
        }
    }
}

using AbstractionLayer;
using System;
using System.IO;

namespace MessageReceiver
{
    public class FileWriter : IFileWriter
    {
        public void Persist(string message)
        {
            using (StreamWriter writetext = new StreamWriter("ThrowMe.txt"))
            {
                writetext.WriteLine(message);
            }
            Console.WriteLine("");
            Console.WriteLine("Your message {0} have been Persisted",message);
            Console.WriteLine("");
            Console.WriteLine("");
        }
}
}

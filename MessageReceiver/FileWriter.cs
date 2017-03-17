using AbstractionLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDouble;

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

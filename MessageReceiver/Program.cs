using AbstractionLayer;
using Ninject;
using System;
using System.IO;

namespace MessageReceiver
{
    class Program
    {
        static void Main(string[] args)
        {

            Watch();
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        static FileSystemWatcher watcher;

        private static void Watch()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = Directory.GetCurrentDirectory();
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                   | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "Message*.txt";
            watcher.Created += new FileSystemEventHandler(OnCreation);
            watcher.EnableRaisingEvents = true;
        }

        private static void OnCreation(object source, FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath))
            {
                Console.WriteLine("File: " + e.FullPath + " " + e.Name);
                string messageContent = String.Join(" ", File.ReadAllLines(e.FullPath));

                using (var kernel = new Ninject.StandardKernel())
                {
                    kernel.Load(@"FileSystemPlugin.xml");

                    bool ismodule = kernel.HasModule("FileSystemPlugin");//To Check The module 

                    if (ismodule)
                    {
                        var fileWriter = kernel.Get<IFileWriter>();
                        fileWriter.Persist(messageContent);
                    }
                }
            }
            File.Delete(e.FullPath);
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}

using AbstractionLayer;
using System;
using TechTalk.SpecFlow;

namespace TestDouble
{
    [Binding]
    public class FileManagerFunnyStub : IFileWriter
    {
        public void Persist(string message)
        {
            Console.WriteLine("");
            Console.WriteLine("I'm a FunyStub");
            Console.WriteLine("");
            Console.WriteLine("I do not persist the file and I do something funny");
            Console.WriteLine("");
            Console.WriteLine(message);
            Console.WriteLine(message + message);
            Console.WriteLine(message + message + message);
            Console.WriteLine(message + message + message + message);
            Console.WriteLine(message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message);
            Console.WriteLine(message + message + message);
            Console.WriteLine(message + message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message + message);
            Console.WriteLine(message + message + message);
            Console.WriteLine(message + message + message + message);
            Console.WriteLine(message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message);
            Console.WriteLine(message + message + message);
            Console.WriteLine(message + message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message + message);
            Console.WriteLine(message + message + message);
            Console.WriteLine(message + message + message + message);
            Console.WriteLine(message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message + message);
            Console.WriteLine(message + message + message + message + message);
            Console.WriteLine(message + message + message);
            Console.WriteLine(message + message);

        }

        private Assembly Config
        {
            get
            {
                Assembly myAssembly = new Assembly();
                myAssembly.BindName = "Observe";
                myAssembly.Service = "AbstractionLayer.IFileWriter, AbstractionLayer";
                myAssembly.To = "TestDouble.FileManagerFunnyStub, TestDouble";
                return myAssembly;
            }
        }

        public void Inject()
        {
            new SetConfiguration().WriteFile(Config);
        }

        //[BeforeScenario("FunnyStub")]
        //public void BeforeScenario()
        //{
        //    Inject();
        //}
    }
}

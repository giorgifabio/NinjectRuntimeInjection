using AbstractionLayer;
using MessageReceiver_BDD_Test.Utility;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MessageReceiver_BDD_Test.TestDouble
{
    [Binding]
    public class FileManagerSimpleStub : IFileWriter
    {
        public void Persist(string message)
        {
            Console.WriteLine("");
            Console.WriteLine("I'm FileManagerSimpleStub");
            Console.WriteLine("");
            Console.WriteLine("I'm do not persist the message and do not do anything else... I'm useless :-(");
            Console.WriteLine("");
        }

        private static Assembly Config
        {
            get
            {
                Assembly myAssembly = new Assembly();
                myAssembly.BindName = "AutoAssert";
                myAssembly.Service = "AbstractionLayer.IFileWriter, AbstractionLayer";
                myAssembly.To = "MessageReceiver_BDD_Test.TestDouble.FileManagerSimpleStub, MessageReceiver_BDD_Test";
                return myAssembly;
            }
        }

        public void Inject()
        {
            new SetConfiguration().WriteFile(Config);
        }

        [BeforeScenario("SimpleStub")]
        public void BeforeScenario()
        {
            Inject();
        }

        [AfterScenario("SimpleStub")]
        public void AfterScenario()
        {
            Thread.Sleep(200); // Please assert something and remove me!
            new SetConfiguration().SetDefault();
        }
    }
}

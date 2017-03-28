using System.Xml;

namespace MessageReceiver_BDD_Test.Utility
{
    public class SetConfiguration
    {
        private Assembly Default
        {
            get
            {
                Assembly myAssembly = new Assembly();
                myAssembly.BindName = "Default";
                myAssembly.Service = "AbstractionLayer.IFileWriter, AbstractionLayer";
                myAssembly.To = "MessageReceiver.FileWriter, MessageReceiver";
                return myAssembly;
            }
        }

        public void SetDefault()
        {
            WriteFile(Default);
        }

        public void WriteFile(Assembly fileWriter)
        {
            //ho to overwrite the file on Azure
            //Test WebServices?
            //execute all the tests in azure infra VM (locally)
            XmlDocument doc = new XmlDocument();
            doc.Load("FileSystemPlugin.xml"); 
            XmlNode countNode = doc.SelectSingleNode("/module/bind");

            countNode.Attributes["name"].Value = fileWriter.BindName;
            countNode.Attributes["service"].Value = fileWriter.Service;
            countNode.Attributes["to"].Value = fileWriter.To;

            doc.Save("FileSystemPlugin.xml");
        }
    }

    public class Assembly
    {
        public string BindName { get; set; }
        public string Service { get; set; }
        public string To { get; set; }
    }
}



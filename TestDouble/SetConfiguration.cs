//<module name = "FileSystemPlugin" >
//  < bind name="AutoAssert"
//              service="AbstractionLayer.IFileManager, AbstractionLayer"
//              to="TestDouble.FileManagerAutoAssertStub, TestDouble" />
//  <bind name = "Observe"
//              service="AbstractionLayer.IFileManager, AbstractionLayer"
//              to="TestDouble.FileManagerObservableStub, TestDouble" />
//  <bind name = "Default"
//            service="AbstractionLayer.IFileManager, AbstractionLayer"
//            to="NinjectRuntimeInjection.ExternalSystems.FileManager, NinjectRuntimeInjection" />
//</module>


using System.Xml;

namespace TestDouble
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



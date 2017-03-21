using System.IO;
using TechTalk.SpecFlow;


namespace MessageReceiver_BDD_Test.Steps
{
    [Binding]
    public class ChatWithMessageSteps
    {   
        [When(@"I send a message to my receiver application")]
        public void WhenISendAMessageToMyReceiverApplication()
        {
            using (StreamWriter writetext = new StreamWriter("Message00000.txt"))
            {
                writetext.WriteLine("test");
            }
        }
        
        [Then(@"a different message is visualized")]
        public void ThenADifferentMessageIsVisualized()
        {

        }
        
        [Then(@"a funny message is visualized")]
        public void ThenAFunnyMessageIsVisualized()
        {

        }
    }
}

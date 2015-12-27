using System.ServiceModel;
using System.Windows.Forms;
using MessagingMessages;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class FindService : IFindService
    {
        public string GetData(FindMessage value)
        {
            MessageBox.Show("Received wcf message");

            return string.Format("You entered: {0}", value);
        }
    }
}

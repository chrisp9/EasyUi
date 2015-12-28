using System.ServiceModel;
using MessagingMessages;

namespace Server
{
    [ServiceContract]
    public interface IFindService
    {
        [OperationContract]
        string GetData(FindMessage value);

        // TODO: Add your service operations here
    }
}

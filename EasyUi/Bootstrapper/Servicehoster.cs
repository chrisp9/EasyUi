using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace Bootstrapper
{
    public class ServiceHoster
    {
        private static ServiceHost _host;

        public static void Host()
        {
            _host = new ServiceHost(typeof (FindService), new Uri("net.pipe://localhost/easyui"));

            _host.AddServiceEndpoint(
                typeof (IFindService),
                new NetNamedPipeBinding(), 
                "FindService"
                );

            _host.Open();

            Console.WriteLine("The service is ready at {0}", "http://localhost:8080/find");
            Console.WriteLine("Press <Enter> to stop the service.");
        }
    }
}
